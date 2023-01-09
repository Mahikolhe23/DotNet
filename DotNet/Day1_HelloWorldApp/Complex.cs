namespace Maths;

public class Complex
{
    //data member
    private int real;
    private int imag;

    // default constructor
    public Complex()
    {
        this.real = 0;
        this.imag = 0;
    }

    //parameterised constructor
    public Complex(int r, int i)
    {
        this.real = r;
        this.real = i;
    }

    // Property
    public int Real
    {
        get { return this.real; }
        set { this.real = value; }
    }
    public int Imag
    {
        get { return this.imag; }
        set { this.imag = value; }
    }

    //operator over loading
    public static Complex operator +(Complex c1, Complex c2)
    {
        Complex temp = new Complex();
        temp.Real = c1.Real + c2.Real;
        temp.Imag = c1.Imag + c2.Imag;
        return temp;
    }
}
