using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Homework_1
{
    class Task_G_Usb_vs_PS2 : ITask
    {
        enum Type
        {
            Usb,
            Ps2
        }

        struct Mouse
        {
            public int Price;
            public Type Type;
        }

        public void Solve()
        {
            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var usbCount = buf[0];
            var ps2Count = buf[1];
            var universalCount = buf[2];
            int n = int.Parse(Console.ReadLine());
            Mouse[] mice = new Mouse[n];

            for (int i = 0; i < n; i++)
            {
                var mouseBuf = Console.ReadLine().Split().ToArray();
                var mouse = new Mouse
                {
                    Price = int.Parse(mouseBuf[0]),
                    Type = mouseBuf[1] == "USB" ? Type.Usb : Type.Ps2
                };
                mice[i] = mouse;
            }

            var sortedMice = mice.OrderBy(m => m.Price).ToArray();
            long totalSum = 0;
            int totalCount = 0;

            for (int i = 0; i < n && (usbCount > 0 || ps2Count > 0 || universalCount > 0); i++)
            {
                var mouse = sortedMice[i];
                if (mouse.Type == Type.Usb && usbCount > 0)
                {
                    totalCount++;
                    totalSum += mouse.Price;
                    usbCount--;
                }
                else if (mouse.Type == Type.Ps2 && ps2Count > 0)
                {
                    totalCount++;
                    totalSum += mouse.Price;
                    ps2Count--;
                }
                else if (universalCount > 0)
                {
                    totalCount++;
                    totalSum += mouse.Price;
                    universalCount--;
                }
            }

            Console.WriteLine($"{totalCount} {totalSum}");
        }
    }
}
