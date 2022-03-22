namespace brainfuck
{
    public static class Utilities
    {
        public static void ShiftRight<T>(IList<T?> list, int numberOfShifts)
        {
            for (var index = list.Count - numberOfShifts - 1; index >= 0; index--)
                list[index + numberOfShifts] = list[index];

            for (var index = 0; index < numberOfShifts; index++)
                list[index] = default(T);
        }
    }
}