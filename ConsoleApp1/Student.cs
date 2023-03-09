namespace Example;

public class Student
{
    private int mNumber;
    private int mScore;

    public Student(int number, int score)
    {
        mNumber = number;
        mScore = score;
    }

    public int getNumber()
    {
        return mNumber;
    }

    public int getScore()
    {
        return mScore;
    }
}
