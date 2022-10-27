using TaiwanStock.Utility;

namespace TestProject1
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		/// <summary>
		/// ´ú¸Õ¤é´Á
		/// </summary>
		[TestCase("2022/10/29 10:00", false)]
		[TestCase("2022-10-20 10:00", true)]
		public void TestWeekday(DateTime input ,bool expected)
		{
			Class1 obj = new Class1();
			bool result = obj.isTradingTime(input);
			Assert.AreEqual(expected, result);
		}

		[TestCase("2022-10-20 13:30", true)]
		[TestCase("2022-10-20 13:31", false)]
		public void TestTime(DateTime input, bool expected)
		{
			Class1 obj = new Class1();
			bool result = obj.isTradingTime(input);
			Assert.AreEqual(expected, result);
		}
	}
}