using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Kurumi {
    class Program {
        static void Main(string[] args) {
            KurumiForm form = new KurumiForm();

            Application.Run(form);
        }

        /// <summary>
        /// Tries to get the network time a few times
        /// </summary>
        /// <returns>The network time or an exception lol</returns>
        public static DateTime TryGetNetworkTime() {
            int tries = 10;
            while (tries-- > 0) {
                try {
                    return GetNetworkTime();
                } catch { }
            }
            throw new Exception("Could not connect");
        }

        /// <summary>
        /// Gets the network time
        /// </summary>
        /// <returns>The network time</returns>
        public static DateTime GetNetworkTime() {
            const string ntpServer = "pool.ntp.org"; // yeah it's hardcoded sorry
            byte[] ntpData = new byte[48];
            ntpData[0] = 0x1B;
            IPAddress[] addresses = Dns.GetHostEntry(ntpServer).AddressList;
            IPEndPoint ipEndPoint = new IPEndPoint(addresses[0], 123);

            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)) {
                socket.Connect(ipEndPoint);
                socket.ReceiveTimeout = 3000;
                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket.Close();
            }

            const byte serverReplyTime = 40;
            
            ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);
            ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);
            
            intPart = SwapEndianness(intPart);
            fractPart = SwapEndianness(fractPart);

            ulong milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);
            DateTime networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

            return networkDateTime.ToLocalTime();
        }
        
        /// <summary>
        /// This changes the endianness of an ulong
        /// </summary>
        /// <param name="x">The ulong</param>
        /// <returns>The ulong, but with swapped endianness</returns>
        static uint SwapEndianness(ulong x) {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }

        //////////////////////

        [DllImport("kernel32.dll")]
        public static extern bool SetSystemTime(ref SYSTEMTIME time);

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEMTIME {
            public ushort Year;
            public ushort Month;
            public ushort DayOfWeek;
            public ushort Day;
            public ushort Hour;
            public ushort Minute;
            public ushort Second;
            public ushort Milliseconds;

            public SYSTEMTIME(DateTime dt) {
                Year = (ushort)dt.Year;
                Month = (ushort)dt.Month;
                DayOfWeek = (ushort)dt.DayOfWeek;
                Day = (ushort)dt.Day;
                Hour = (ushort)dt.Hour;
                Minute = (ushort)dt.Minute;
                Second = (ushort)dt.Second;
                Milliseconds = (ushort)dt.Millisecond;
            }
        }
    }
}
