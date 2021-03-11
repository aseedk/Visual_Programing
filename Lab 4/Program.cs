namespace Lab_4
{
    public abstract class A
    {
        public abstract void DoWork(int i);
    }

    public class D
    {
        public virtual void DoWork(int i)
        {
            
        }
    }

    public abstract class E : D
    {
        public abstract override void DoWork(int i);
    }

    public class F : E
    {
        public override void DoWork(int i)
        {
            throw new System.NotImplementedException();
        }

        /*public new void DoWork(int i)
        {
            
        }*/
    }

    internal interface IEquatable<in T>
    {
        bool Equals(T obj);
    }

    public class Car : IEquatable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public bool Equals(Car obj)
        {
            throw new System.NotImplementedException();
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}