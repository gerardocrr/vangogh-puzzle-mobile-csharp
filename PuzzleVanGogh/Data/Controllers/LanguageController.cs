namespace PuzzleVanGogh.Data.Controllers
{
    public class LanguageController
    {
        private Language.LanguageES ES = new Language.LanguageES();
        private Language.LanguageEN EN = new Language.LanguageEN();

        public void LanguageIndex(string language, ref string lbluser, ref string btnaccept, ref string toast1)
        {
            if (language == "es")
            {
                lbluser = ES.ES["username"];
                btnaccept = ES.ES["accept"];
                toast1 = ES.ES["toast1User"];
            }
            else if (language == "en")
            {
                lbluser = EN.EN["username"];
                btnaccept = EN.EN["accept"];
                toast1 = EN.EN["toast1User"];
            }
        }

        public void LanguageMainLevels(ref string language, ref string levels)
        {
            if (language == "es")
            {
                levels = ES.ES["levels"];
            }
            else if (language == "en")
            {
                levels = EN.EN["levels"];
            }
        }

        public void LanguageUserSettings(string language, ref string usersText, ref string selectText, ref string newUser, ref string languageText, ref string toast1, ref string toast2)
        {
            if (language == "es")
            {
                usersText = ES.ES["users"];
                selectText = ES.ES["selectUser"];
                newUser = ES.ES["newUser"];
                languageText = ES.ES["language"];
                toast1 = ES.ES["toast1User"];
                toast2 = ES.ES["toast2User"];
            }
            else if (language == "en")
            {
                usersText = EN.EN["users"];
                selectText = EN.EN["selectUser"];
                newUser = EN.EN["newUser"];
                languageText = EN.EN["language"];
                toast1 = EN.EN["toast1User"];
                toast2 = EN.EN["toast2User"];
            }
        }

        public void LanguageButtons(ref string language, ref string start, ref string resolve, ref string hint, ref string scores, ref string restart)
        {
            if (language == "es")
            {
                start = ES.ES["start"];
                resolve = ES.ES["resolve"];
                hint = ES.ES["hint"];
                scores = ES.ES["scores"];
                restart = ES.ES["restart"];
            }
            else if (language == "en")
            {
                start = EN.EN["start"];
                resolve = EN.EN["resolve"];
                hint = EN.EN["hint"];
                scores = EN.EN["scores"];
                restart = EN.EN["restart"];
            }
        }

        public void ModalDelete(ref string language, ref string delete, ref string cancel, ref string title, ref string content1, ref string content2)
        {
            if (language == "es")
            {
                delete = ES.ES["delete"];
                cancel = ES.ES["cancel"];
                title = ES.ES["titleDelete"];
                content1 = ES.ES["content1Delete"];
                content2 = ES.ES["content2Delete"];
            }
            else if (language == "en")
            {
                delete = EN.EN["delete"];
                cancel = EN.EN["cancel"];
                title = EN.EN["titleDelete"];
                content1 = EN.EN["content1Delete"];
                content2 = EN.EN["content2Delete"];
            }
        }

        public void ModalWin(ref string language, ref string title, ref string content1, ref string content2, ref string accept, ref string seconds)
        {
            if (language == "es")
            {
                title = ES.ES["congratulations"];
                content1 = ES.ES["content1Win"];
                content2 = ES.ES["content2Win"];
                accept = ES.ES["accept"];
                seconds = ES.ES["seconds"];
            }
            else if (language == "en")
            {
                title = EN.EN["congratulations"];
                content1 = EN.EN["content1Win"];
                content2 = EN.EN["content2Win"];
                accept = EN.EN["accept"];
                seconds = EN.EN["seconds"];
            }
        }

        public void ModalBestTime(ref string language, ref string title, ref string content1, ref string content2, ref string accept, ref string seconds)
        {
            if (language == "es")
            {
                title = ES.ES["congratulations"];
                content1 = ES.ES["bestTime"];
                content2 = ES.ES["content2Win"];
                accept = ES.ES["accept"];
                seconds = ES.ES["seconds"];
            }
            else if (language == "en")
            {
                title = EN.EN["congratulations"];
                content1 = EN.EN["bestTime"];
                content2 = EN.EN["content2Win"];
                accept = EN.EN["accept"];
                seconds = EN.EN["seconds"];
            }
        }

        public void ModalScores(ref string language, ref string scores, ref string name, ref string time)
        {
            if (language == "es")
            {
                scores = ES.ES["scores"];
                name = ES.ES["user"];
                time = ES.ES["time"];
            }
            else if (language == "en")
            {
                scores = EN.EN["scores"];
                name = EN.EN["user"];
                time = EN.EN["time"];
            }
        }

        public void ModalNoti(ref string language, ref string title, ref string content, ref string accept)
        {
            if (language == "es")
            {
                title = ES.ES["attention"];
                content = ES.ES["contentNoti"];
                accept = ES.ES["accept"];
            }
            else if (language == "en")
            {
                title = EN.EN["attention"];
                content = EN.EN["contentNoti"];
                accept = EN.EN["accept"];
            }
        }
    }
}
