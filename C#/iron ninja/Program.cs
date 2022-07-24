// See https://aka.ms/new-console-template for more information
using System;

namespace IronNinja
{
    class program
    {
        static void Main(string[] arg)
        {
            Buffet buffet1 = new Buffet();
            SpiceHound sh = new SpiceHound();
            SweetTooth st = new SweetTooth();

            Random rnd = new Random();
            int rand = rnd.Next(0, 7);
            int rand1 = rnd.Next(0, 7);


            sh.Consume(buffet1.Menu[rnd.Next(0, 7)]);
            sh.Consume(buffet1.Menu[rnd.Next(0, 7)]);
            sh.Consume(buffet1.Menu[rnd.Next(0, 7)]);

            st.Consume(buffet1.Menu[rnd.Next(0, 7)]);
            if (sh.ConsumptionHistory.Count > st.ConsumptionHistory.Count)
            {
                int cons = sh.ConsumptionHistory.Count - st.ConsumptionHistory.Count;
                Console.WriteLine($"SweetTooth consumed {cons} more");
            }
            else if (sh.ConsumptionHistory.Count == st.ConsumptionHistory.Count)
            {
                st.Consume(buffet1.Menu[rnd.Next(0, 7)]);
                Console.WriteLine($"SweetTooth and SpiceHound consumed both{sh.ConsumptionHistory.Count}");
            }
            else
            {
                int con = st.ConsumptionHistory.Countsh.ConsumptionHistory.Count;
                Console.WriteLine($"SpiceHound consumed {con} more");
            }

        }

    }

}
