namespace 备忘录模式
{
    public class Memento
    {
        public string State { get; set; } 
        public Memento(string state)
        {
            this.State = state;
        }
    }
}