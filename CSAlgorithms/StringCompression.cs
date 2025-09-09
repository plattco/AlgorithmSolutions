namespace DefaultNamespace;

public int Compress(char[] chars)
{
    int writeIndex = 0;
    int readIndex = 0;

    while (readIndex < chars.Length)
    {
        char currentChar = chars[readIndex];
        int count = 0;
        while (readIndex < chars.Length && chars[readIndex] == currentChar)
        {
            readIndex++;
            count++;
        }
        chars[writeIndex++] = currentChar;
        if (count > 1)
        {
            string countStr = count.ToString();
            foreach (char digit in countStr)
            {
                chars[writeIndex++] = digit;
            }
        }
    }
    return writeIndex;
}