namespace Lesson_4
{
    class Model
    {
        // арифметические операции
        public string Add(int a, int b)
        {
            return (a + b).ToString();
        }
        public string Sub(int a, int b)
        {
            return (a - b).ToString();
        }
        public string Mul(int a, int b)
        {
            return (a * b).ToString();
        }
        public string Div(int a, int b)
        {
            return b != 0 ? ((double)a / b).ToString() : "DivideByZero";
        }

    }
}
