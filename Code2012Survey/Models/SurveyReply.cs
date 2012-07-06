using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Code2012Survey.Properties;

namespace Code2012Survey.Models
{
    public class SurveyReply
    {
        // replay of Q1. "Why do you write code?"
        [Display(ResourceType = typeof(LocalizeText), Name = "Choice1OfQ1")]
        public bool Choice1OfQ1 { get; set; }

        [Display(ResourceType = typeof(LocalizeText), Name = "Choice2OfQ1")]
        public bool Choice2OfQ1 { get; set; }

        [Display(ResourceType = typeof(LocalizeText), Name = "Choice3OfQ1")]
        public bool Choice3OfQ1 { get; set; }

        [Display(ResourceType = typeof(LocalizeText), Name = "Choice4OfQ1")]
        public bool Choice4OfQ1 { get; set; }

        [Display(ResourceType = typeof(LocalizeText), Name = "Choice5OfQ1")]
        public bool Choice5OfQ1 { get; set; }

        [Display(ResourceType = typeof(LocalizeText), Name = "Choice6OfQ1")]
        public bool Choice6OfQ1 { get; set; }

        // replay of Q2. "How many years do you write code?"
        public int? CodingForYears { get; set; }

        // replay of Q3. "Where do you live ine? or come from?"
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Address { get; set; }

        // replay of Q4. "Please comment here."
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Comment { get; set; }
    }
}