using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKataBase
{
    /// <summary>
    /// An example public class.
    /// https://www.geeksforgeeks.org/c-sharp-class-and-object/
    /// </summary>
    public class ExampleClass
    {
        /// <summary>
        /// An example property with a public getter and a private setter.
        /// https://www.geeksforgeeks.org/c-sharp-properties/
        /// </summary>
        public string ObjectName { get; private set; }

        /// <summary>
        /// An array of characters from the ObjectName.
        /// https://www.geeksforgeeks.org/c-sharp-arrays/
        /// </summary>
        private char[] nameCharacters;

        /// <summary>
        /// An example non-default constructor with a parameter.
        /// https://www.geeksforgeeks.org/c-sharp-constructors/
        /// </summary>
        /// <param name="name">The name of the object when it is created.</param>
        public ExampleClass(string name)
        {
            // When the object is created it sets the value of the property to the parameter.
            // Assignment of a value: https://www.geeksforgeeks.org/c-sharp-operators/
            this.ObjectName = name;

            // https://www.geeksforgeeks.org/c-sharp-tochararray-method/
            this.nameCharacters = this.ObjectName.ToCharArray();
        }

        /// <summary>
        /// A public function that calls a private function.
        /// https://www.geeksforgeeks.org/c-sharp-methods/
        /// </summary>
        public void PrintDetails()
        {
            this.PrintName();
        }

        /// <summary>
        /// A private function that prints the property.
        /// </summary>
        private void PrintName()
        {
            Console.WriteLine(this.ObjectName);
        }

        private void PrintCharacters()
        {
            // https://www.geeksforgeeks.org/c-sharp-using-foreach-loop-in-arrays/
            foreach (var character in this.nameCharacters)
            {
                Console.Write(character);
            }
        }
    }
}
