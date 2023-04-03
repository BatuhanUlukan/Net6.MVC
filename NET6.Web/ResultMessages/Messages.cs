namespace NET6.Web.ResultMessages
{
    public static class Messages
    {
        public static class Article
        {
            public static string Add(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla eklenmiştir.";
            }
            public static string Update(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla güncellenmiştir.";
            }
            public static string Delete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla silinmiştir.";
            }
            public static string UndoDelete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla geri alınmıştır.";
            }
        }
        public static class Category
        {
            public static string Add(string categoryName)
            {
                return $"{categoryName} başlıklı kategori başarıyla eklenmiştir.";
            }
            public static string Update(string categoryName)
            {
                return $"{categoryName} başlıklı kategori başarıyla güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} başlıklı kategori başarıyla silinmiştir.";
            }
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} başlıklı kategori başarıyla geri alınmıştır.";
            }
        }
        public static class User
        {
            public static string Add(string userName)
            {
                return $"{userName} email adresli kullanıcı başarıyla eklenmiştir.";
            }
            public static string Update(string userName)
            {
                return $"{userName} email adresli kullanıcı başarıyla güncellenmiştir.";
            }
            public static string Delete(string userName)
            {
                return $"{userName} email adresli kullanıcı başarıyla silinmiştir.";
            }
        }

        public static class Portfolio
        {
            public static string Add(string portfolioTitle)
            {
                return $"{portfolioTitle} başlıklı portfolyo başarıyla eklenmiştir.";
            }
            public static string Update(string portfolioTitle)
            {
                return $"{portfolioTitle} başlıklı portfolyo başarıyla güncellenmiştir.";
            }
            public static string Delete(string portfolioTitle)
            {
                return $"{portfolioTitle} başlıklı portfolyo başarıyla silinmiştir.";
            }
            public static string UndoDelete(string portfolioTitle)
            {
                return $"{portfolioTitle} başlıklı portfolyo başarıyla geri alınmıştır.";
            }
        }

        public static class History
        {
            public static string Add(string historyTitle)
            {
                return $"{historyTitle} başlıklı geçmiş başarıyla eklenmiştir.";
            }
            public static string Update(string historyTitle)
            {
                return $"{historyTitle} başlıklı geçmiş başarıyla güncellenmiştir.";
            }
            public static string Delete(string historyTitle)
            {
                return $"{historyTitle} başlıklı geçmiş başarıyla silinmiştir.";
            }
            public static string UndoDelete(string historyTitle)
            {
                return $"{historyTitle} başlıklı geçmiş başarıyla geri alınmıştır.";
            }
        }

        public static class Testimonial
        {
            public static string Add(string testimonialTitle)
            {
                return $"{testimonialTitle} başlıklı tavsiye  başarıyla eklenmiştir.";
            }
            public static string Update(string testimonialTitle)
            {
                return $"{testimonialTitle} başlıklı tavsiye  başarıyla güncellenmiştir.";
            }
            public static string Delete(string testimonialTitle)
            {
                return $"{testimonialTitle} başlıklı tavsiye  başarıyla silinmiştir.";
            }
            public static string UndoDelete(string testimonialTitle)
            {
                return $"{testimonialTitle} başlıklı tavsiye  başarıyla geri alınmıştır.";
            }
        }
        public static class About
        {
            public static string Add(string aboutTitle)
            {
                return $"{aboutTitle} başlıklı tavsiye  başarıyla eklenmiştir.";
            }
            public static string Update(string aboutTitle)
            {
                return $"{aboutTitle} başlıklı tavsiye  başarıyla güncellenmiştir.";
            }
            public static string Delete(string aboutTitle)
            {
                return $"{aboutTitle} başlıklı tavsiye  başarıyla silinmiştir.";
            }
            public static string UndoDelete(string aboutTitle)
            {
                return $"{aboutTitle} başlıklı tavsiye  başarıyla geri alınmıştır.";
            }
        }
        public static class Process
        {
            public static string Add(string processTitle)
            {
                return $"{processTitle} başlıklı tavsiye  başarıyla eklenmiştir.";
            }
            public static string Update(string processTitle)
            {
                return $"{processTitle} başlıklı tavsiye  başarıyla güncellenmiştir.";
            }
            public static string Delete(string processTitle)
            {
                return $"{processTitle} başlıklı tavsiye  başarıyla silinmiştir.";
            }
            public static string UndoDelete(string processTitle)
            {
                return $"{processTitle} başlıklı tavsiye  başarıyla geri alınmıştır.";
            }
        }
        public static class Skill
        {
            public static string Add(string skillTitle)
            {
                return $"{skillTitle} başlıklı yetenek  başarıyla eklenmiştir.";
            }
            public static string Update(string skillTitle)
            {
                return $"{skillTitle} başlıklı yetenek  başarıyla güncellenmiştir.";
            }
            public static string Delete(string skillTitle)
            {
                return $"{skillTitle} başlıklı yetenek  başarıyla silinmiştir.";
            }
            public static string UndoDelete(string skillTitle)
            {
                return $"{skillTitle} başlıklı yetenek  başarıyla geri alınmıştır.";
            }
        }
    }

}

