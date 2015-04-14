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

        public object alphaOrderConsonants()
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
    }
    
    
}
