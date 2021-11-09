using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression(1, 2);
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            arithProgression.setStart(5);
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            arithProgression.reset();
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());

            Console.WriteLine();
            
            GeomProgression geomProgression = new GeomProgression(1, 2);
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            geomProgression.setStart(5);
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            geomProgression.reset();
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    public class ArithProgression : ISeries
    {
        int Member { get; set; }
        int Start { get; set; }
        int Step { get; set; }
        public ArithProgression(int start, int step)
        {
            Member = start;
            Step = step;
        }
        public int getNext()
        {
            return Member += Step;
        }

        public void reset()
        {
            Member = Start;
        }

        public void setStart(int x)
        {
            Member = x;
            Start = x;       
        }
    }
    public class GeomProgression : ISeries
    {
        int Member { get; set; }
        int Start { get; set; }
        int Denominator { get; set; }
        public GeomProgression(int start, int demnominator)
        {
            Member = start;
            Denominator = demnominator;
        }
        public int getNext()
        {
            return Member *= Denominator;
        }

        public void reset()
        {
            Member = Start;
        }

        public void setStart(int x)
        {
            Member = x;
            Start = x;
        }
    }
}
