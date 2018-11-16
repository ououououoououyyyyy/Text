﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_TextHandler.TextObject
{
    public class Sentence
    {
        public ICollection<Word> SentenceList { get; set; }

        public Sentence(ICollection<Word> sentenceList)
        {
            SentenceList = sentenceList;
        }
    }
}
