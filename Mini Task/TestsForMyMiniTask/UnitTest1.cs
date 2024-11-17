using Mini_Task;

namespace TestsForMyMiniTask
{
    public class UnitTest1
    {
        [Fact]
        public void �hecking_whether_text_is_included_in_width_of_sheet()
        {
            Assert.True(MyTask.CheckLengthOfLineText("Hello", 7));
            Assert.False(MyTask.CheckLengthOfLineText("Hello", 4));
        }


        [Fact]
        public void Adding_spaces_at_beginning_and_at_end_of_string()
        {
            string expected = "++++++������!+++++++\n++++������ ���.+++++\n++++++���� =)+++++++\n";
            string[] parametr = { "20 3", "������!", "������ ���.", "���� =)" };
            string result = MyTask.RearrangingStringsInCenterOfSheet(parametr);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void checking_fot_the_correctness_of_int_parsing()
        {
            Assert.Equal(123, MyTask.parseInt("123"));
            Assert.Equal(-123, MyTask.parseInt("-123"));
            Assert.Equal(0, MyTask.parseInt("0"));
        }

        [Fact]
        public void checking_fot_the_correctness_of_int_parsing_with_Exception()
        {
            Assert.Throws<Exception>(() => MyTask.parseInt("12,3"));
            Assert.Throws<Exception>(() => MyTask.parseInt("sometext"));
            Assert.Throws<Exception>(() => MyTask.parseInt(""));
        }
    }
}