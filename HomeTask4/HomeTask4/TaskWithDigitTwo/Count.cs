

namespace HomeTask4.TaskWithDigitTwo
{
   public class Count
    {
        int _counter=0;
        public int CountOperations(int number)
        {
             do
              {
                  if (number%2==0)
                  {
                      number = number / 2;
                      _counter++;
                  }
                  else
                  {

                     number = --number;
                      _counter++;
                  }

              } while (number/2!=1);

           /* for (; number==2 ;_counter++)
            {
                if (number % 2 == 0)
                {
                    number = number / 2;
                    //_counter++;
                }
                else
                {

                    number = --number;
                    //_counter++;
                }
            }*/
            return _counter;
        }
    }
}
