using System;

namespace Homework1
{
    public struct Task5_ComplexNumber
    {
       public int real;
       public int imaginary;

       public Task5_ComplexNumber(int real, int imaginary)
       {
          this.real = real;
          this.imaginary = imaginary;
       }

       #region Static Methods

       public static Task5_ComplexNumber operator *(Task5_ComplexNumber one, Task5_ComplexNumber two)
       {
           return new Task5_ComplexNumber(one.real * two.real - one.imaginary * two.imaginary, 
               one.real * two.imaginary + one.imaginary * two.real);
       }
       
       public static Task5_ComplexNumber operator /(Task5_ComplexNumber one, Task5_ComplexNumber two)
       {
           return new Task5_ComplexNumber((one.real * two.real + one.imaginary * two.imaginary) / two.real * two.real + two.imaginary * two.imaginary,
               (one.imaginary * two.real - one.real * two.imaginary) / two.real * two.real + two.imaginary * two.imaginary);
       }

       public override string ToString()
       {
           return (String.Format("{0} + {1}i", real, imaginary));
       }

       #endregion
       
    }
}