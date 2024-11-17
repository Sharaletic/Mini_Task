using Mini_Task;

namespace TestsForMyMiniTask
{
    public class UnitTest1
    {
        [Fact]
        public void �hecking_whether_text_is_included_in_width_of_sheet()
        {
            bool result = MyTask.CheckLengthOfLineText("Hello", 7);
            Assert.True(result);
        }

        [Fact]
        public void Checking_read_file()
        {
            string[] expected = { "20 3", "������!", "������ ���.", "���� =)" };
            string[] result = MyTask.ReadFile("input.txt");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Adding_spaces_at_beginning_and_at_end_of_string()
        {
            string expected = "++++++������!+++++++\n++++������+���.+++++\n++++++����+=)+++++++";
            string[] parametr = { "20 3", "������!", "������ ���.", "���� =)" };
            string result = MyTask.RearrangingStringsInCenterOfSheet(parametr);
            Assert.Equal(expected, result);
        }
    }
}