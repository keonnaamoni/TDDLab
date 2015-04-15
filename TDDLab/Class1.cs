using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLab
{
    public class StringInput {

        private string p;

        public StringInput(string p)
        {
            this.p = p;
        }

        public IEnumerable<char> pullConsonants()
        {

            var query = from c in p
                        where c != 'a'
                        where c != 'e'
                        where c != 'i'
                        where c != 'o'
                        where c != 'u'
                        where c != ' '
                        where c != '.'
                        select c;

            return query;
        }

        public IEnumerable<char> alphaOrderConsonants()
        {
            var query = from c in p
                        where c != 'a'
                        where c != 'e'
                        where c != 'i'
                        where c != 'o'
                        where c != 'u'
                        where c != ' '
                        where c != '.'
                        select c;

            query = query.OrderBy(c => c);


            return query;
        }

        public IEnumerable<char> RemoveDuplicateChars()

        {
            var query = from c in p
                        select c;
            IEnumerable<char> distinctChars = query.Distinct();

            return distinctChars;
        }

        const string UppcaseChars = "abcdefghijklmnopqrstuvwxyz";

        public IEnumerable<char> OnlyLowerCase()
        {
            var query = from c in p
                        where UppcaseChars.IndexOf(c) != -1
                        where c != 'a'
                        where c != 'e'
                        where c != 'i'
                        where c != 'o'
                        where c != 'u'
                        where c != ' '
                        where c != '.'
                        select c;

            return query;
        }
    }
    
    
}
