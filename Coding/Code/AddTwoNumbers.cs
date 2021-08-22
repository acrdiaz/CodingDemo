using Coding.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Code
{
    class AddTwoNumbers : BaseRun
    {
        #region Attempt 1

        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        private ListNode AddNumbers(ListNode l1, ListNode l2)
        {
            ListNode lroot = null;
            ListNode lstep = null;

            int remainder = 0;
            while (l1 != null || l2 != null || remainder > 0) // && l2.next != null)
            {
                if (lroot == null)
                {
                    lroot = new ListNode();
                    lstep = lroot;
                }
                else
                {
                    lstep.next = new ListNode();
                    lstep = lstep.next;
                }

                int n1 = 0;
                int n2 = 0;
                if (l1 != null)
                {
                    n1 = l1.val;
                }
                if (l2 != null)
                {
                    n2 = l2.val;
                }

                int sum = n1 + n2 + remainder; //16
                int div = sum / 10; //1
                int mod = sum % 10; //6
                remainder = 0;

                lstep.val = mod;

                if (div > 0)
                {
                    remainder = div;
                }

                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }

            return lroot;
        }

        #endregion Attempt 1

        public string GetOutput(ListNode l, string expectedResult = "")
        {
            StringBuilder sb = new StringBuilder();
            string tmp = string.Empty;
            while (l != null)
            {
                tmp = l.val.ToString();
                l = l.next;
                if (l != null)
                {
                    tmp += ", ";
                }
                sb.Append(tmp);
            }
            string ret = $"[{sb}]";
            return $"{ret == expectedResult}: {ret} == {expectedResult}";
        }

        public override void Run()
        {
            ListNode l1 = null;
            ListNode l2 = null;
            ListNode l3;
            string ret = string.Empty;

            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
                        l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
                        ret = "[7, 0, 8]";
                        break;
                    case 1:
                        l1 = new ListNode(0);
                        l2 = new ListNode(0);
                        ret = "[0]";
                        break;
                    case 2:
                        l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
                        l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
                        ret = "[8, 9, 9, 9, 0, 0, 0, 1]";
                        break;
                    case 3:
                        l1 = new ListNode(0);
                        l2 = new ListNode(7, new ListNode(3));
                        ret = "[7, 3]";
                        break;
                } // switch

                l3 = AddNumbers(l1, l2);
                Console.WriteLine(GetOutput(l3, ret));
            } // for
        }
    }
}
