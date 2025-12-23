using System;

public class StudentVoteChecker
{
	public bool CanStudentVote(int age)
	{
		if (age < 0 || age <18)
		{
			return false;
		}
	return true;

	}
}
