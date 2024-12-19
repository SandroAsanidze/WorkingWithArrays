﻿using System;

namespace WorkingWithArrays
{
    public static class CreatingArray
    {
        public static int[] CreateEmptyArrayOfIntegers()
        {
            // TODO #1-1. Add the method implementation. The method should return an empty array.
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty

            int[] emptyArray = Array.Empty<int>();
            return emptyArray;
        }

        public static bool[] CreateEmptyArrayOfBooleans()
        {
            // TODO #1-2. Add the method implementation. The method should return an empty array.
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            bool[] emptyArray = Array.Empty<bool>();
            return emptyArray;
        }

        public static string[] CreateEmptyArrayOfStrings()
        {
            // TODO #1-3. Add the method implementation. The method should return an empty array.
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            string[] emptyArray = Array.Empty<string>();
            return emptyArray;
        }

        public static char[] CreateEmptyArrayOfCharacters()
        {
            // TODO #1-4. Add the method implementation. The method should return an empty array.
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            char[] emptyArray = Array.Empty<char>();
            return emptyArray;
        }

        public static double[] CreateEmptyArrayOfDoubles()
        {
            // TODO #1-5. Add the method implementation. The method should return an empty array.
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            double[] emptyArray = Array.Empty<double>();
            return emptyArray;
        }

        public static float[] CreateEmptyArrayOfFloats()
        {
            // TODO #1-6. Add the method implementation. The method should return an empty array.
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            float[] emptyArray = Array.Empty<float>();
            return emptyArray;
        }

        public static decimal[] CreateEmptyArrayOfDecimals()
        {
            // TODO #1-7. Add the method implementation. The method should return an empty array.
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            decimal[] emptyArray = Array.Empty<decimal>();
            return emptyArray;
        }

        public static int[] CreateArrayOfTenIntegersWithDefaultValues()
        {
            // TODO #1-8. Add the method implementation. The method should return an array that contains ten integers with default values.
            int[] array = new int[10];
            return array;
        }

        public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
        {
            // TODO #1-9. Add the method implementation. The method should return an array that contains twenty booleans with default values.
            bool[] array = new bool[20];
            return array;
        }

        public static string[] CreateArrayOfFiveEmptyStrings()
        {
            // TODO #1-10. Add the method implementation. The method should return an array that contains five empty strings with default values.
            string[] array = new string[5];
            return array;
        }

        public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
        {
            // TODO #1-11. Add the method implementation. The method should return an array that contains fifteen characters with default values.
            char[] array = new char[15];
            return array;
        }

        public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
        {
            // TODO #1-12. Add the method implementation. The method should return an array that contains eighteen doubles with default values.
            double[] array = new double[18];
            return array;
        }

        public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
        {
            // TODO #1-13. Add the method implementation. The method should return an array that contains one hundred doubles with default values.
            float[] array = new float[100];
            return array;
        }

        public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
        {
            // TODO #1-14. Add the method implementation. The method should return an array that contains one thousand decimals with default values.
            decimal[] array = new decimal[1000];
            return array;
        }

        public static int[] CreateIntArrayWithOneElement()
        {
            // TODO #1-15. Add the method implementation. The method should return an array that contains one integer: 123,456.
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            int[] array = new[] { 123_456 };
            return array;
        }

        public static int[] CreateIntArrayWithTwoElements()
        {
            // TODO #1-16. Add the method implementation. The method should return an array that contains two integers:
            // 1,111,111; 9,999,999
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            int[] array = new[] { 1_111_111, 9_999_999 };
            return array;
        }

        public static int[] CreateIntArrayWithTenElements()
        {
            // TODO #1-17. Add the method implementation. The method should return an array that contains ten integers:
            //  0; 4,234; 3,845; 2,942; 1,104; 9,794; 923,943; 7,537; 4,162; 10,134
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            int[] array = new[] { 0, 4_234, 3_845, 2_942, 1_104, 9_794, 923_943, 7_537, 4_162, 10_134 };
            return array;
        }

        public static bool[] CreateBoolArrayWithOneElement()
        {
            // TODO #1-18. Add the method implementation. The method should return an array that contains one boolean: true.
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            bool[] array = new[] { true };
            return array;
        }

        public static bool[] CreateBoolArrayWithFiveElements()
        {
            // TODO #1-19. Add the method implementation. The method should return an array that contains five booleans:
            //  true; false; true; false; true
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            bool[] array = new[] { true, false, true, false, true };
            return array;
        }

        public static bool[] CreateBoolArrayWithSevenElements()
        {
            // TODO #1-20. Add the method implementation. The method should return an array that contains seven booleans:
            //  false; true; true; false; true; true; false
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            bool[] array = new[] { false, true, true, false, true, true, false };
            return array;
        }

        public static string[] CreateStringArrayWithOneElement()
        {
            // TODO #1-21. Add the method implementation. The method should return an array that contains one string: one.
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            string[] array = new[] { "one" };
            return array;
        }

        public static string[] CreateStringArrayWithThreeElements()
        {
            // TODO #1-22. Add the method implementation. The method should return an array that contains three strings:
            //  one; two; three
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            string[] array = new[] { "one", "two", "three" };
            return array;
        }

        public static string[] CreateStringArrayWithSixElements()
        {
            // TODO #1-23. Add the method implementation. The method should return an array that contains three strings:
            //  one; two; three; four; five; six
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            string[] array = new[] { "one", "two", "three", "four", "five", "six" };
            return array;
        }

        public static char[] CreateCharArrayWithOneElement()
        {
            // TODO #1-24. Add the method implementation. The method should return an array that contains one character: a.
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            char[] array = new[] { 'a' };
            return array;
        }

        public static char[] CreateCharArrayWithThreeElements()
        {
            // TODO #1-25. Add the method implementation. The method should return an array that contains three characters:
            //  a; b; c
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            char[] array = new[] { 'a', 'b', 'c' };
            return array;
        }

        public static char[] CreateCharArrayWithNineElements()
        {
            // TODO #1-26. Add the method implementation. The method should return an array that contains nine characters:
            //  a; b; c; d; e; f; g; h; a
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            char[] array = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' };
            return array;
        }

        public static double[] CreateDoubleArrayWithOneElement()
        {
            // TODO #1-27. Add the method implementation. The method should return an array that contains one double: 1.12.
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            double[] array = new[] { 1.12 };
            return array;
        }

        public static double[] CreateDoubleWithFiveElements()
        {
            // TODO #1-28. Add the method implementation. The method should return an array that contains five doubles:
            //  1.12; 2.23; 3.34; 4.45; 5.56
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            double[] array = new[] { 1.12, 2.23, 3.34, 4.45, 5.56 };
            return array;
        }

        public static double[] CreateDoubleWithNineElements()
        {
            // TODO #1-29. Add the method implementation. The method should return an array that contains nine doubles:
            //  1.12; 2.23; 3.34; 4.45; 5.56; 6.67; 7.78; 8.89; 9.91
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            double[] array = new[] { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 };
            return array;
        }

        public static float[] CreateFloatArrayWithOneElement()
        {
            // TODO #1-30. Add the method implementation. The method should return an array that contains one float: 123,456,789.123456.
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            float[] array = new[] { 123_456_789.12_34_56f };
            return array;
        }

        public static float[] CreateFloatWithThreeElements()
        {
            // TODO #1-31. Add the method implementation. The method should return an array that contains three floats:
            //  1,000,000.123456; 2,223,334,444.123456; 9,999.999999
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            float[] array = new[] { 10_000_00.12_34_56f, 222_333_4444.12_34_56f, 9999.999999f };
            return array;
        }

        public static float[] CreateFloatWithFiveElements()
        {
            // TODO #1-32. Add the method implementation. The method should return an array that contains five floats:
            //  1.0123; 20.012345; 300.01234567; 4,000.01234567; 500,000.01234567
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            float[] array = new[] { 1.01_23f, 20.01_23_45f, 300.01_23_45_67f, 4_000.0123_4567f, 50_0000.01234567f };
            return array;
        }

        public static decimal[] CreateDecimalArrayWithOneElement()
        {
            // TODO #1-33. Add the method implementation. The method should return an array that contains one double: 10,000.123456.
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            decimal[] array = new[] { 10_000.12_34_56m };
            return array;
        }

        public static decimal[] CreateDecimalWithFiveElements()
        {
            // TODO #1-34. Add the method implementation. The method should return an array that contains four doubles:
            //  1,000.1234; 100,000.2345; 100,000.3456; 1,000,000.456789; 10,000,000.5678901
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            decimal[] array = new[] { 1_000.12_34m, 10_0000.23_45m, 100_000.34_56m, 1_000_000.4567_89m, 10000000.5678901m };
            return array;
        }

        public static decimal[] CreateDecimalWithNineElements()
        {
            // TODO #1-35. Add the method implementation. The method should return an array that contains ten doubles:
            //  10.122112; 200.233223; 3,000.344334; 40,000.455445; 500,000.566556; 6,000,000.677667; 70,000,000.788778; 800,000,000.899889; 9,000,000,000.911991
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            decimal[] array = new[] { 10.12_21_12M, 200.23_32_23M, 3_000.34_43_34M, 40_000.45_54_45M, 500_000.56_65_56M, 6_000_000.67_76_67M, 70_000_000.78_87_78M, 800_000_000.89_98_89M, 9_000_000_000.91_19_91M };
            return array;
        }
    }
}
