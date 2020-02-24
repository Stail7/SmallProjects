using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<DateTime> date = null;
            // OR
            DateTime? date2 = null;

            Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            //Console.WriteLine("Value: " + date.Value); // extension if the value is null

            DateTime? date3 = new DateTime(2015, 1, 1);
            DateTime date4 = date3.GetValueOrDefault();
            Console.WriteLine(date4);

            // ?? Null Coalescing operator
            
            DateTime date5;

            if (date2 != null)
                date5 = date.GetValueOrDefault();
            else
                date5 = DateTime.Today;
            // OR
            date5 = date != null ? date.GetValueOrDefault() : DateTime.Today;
            // OR
            date5 = date ?? DateTime.Today; // if 'date' has a value than assign that value to 'date5'
                                            // if 'date == null' assign DateTime.Today to 'date5'
        }
    }
}
