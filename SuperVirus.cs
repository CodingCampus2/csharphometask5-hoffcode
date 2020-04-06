using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    public class SuperVirus : Task5.Virus
    {
        private float m_KillProbability;
        private string m_Name;
        private string m_VictimName;
        private readonly DateTime m_CreationTime;

        public SuperVirus()
            : base(false)
        {
            m_CreationTime = DateTime.UtcNow;
        }

        public override float KillProbability
        {
            get
            {
                return m_KillProbability;
            }

            set
            {
                m_KillProbability = value * 2f;
                if (m_KillProbability > 1f)
                {
                    m_KillProbability = 1f;
                }
            }
        }

        public override string Name
        {
            get
            {
                return m_Name;
            }

            set
            {
                m_Name = value;
                int indexOfVirusWord = m_Name.IndexOf("virus");
                if (indexOfVirusWord == -1)
                {
                    m_Name += "supervirus";
                }
                else
                {
                    m_Name = m_Name.Insert(indexOfVirusWord, "super");
                }
            }
        }

        public override string VictimName 
        {
            get
            {
                return m_VictimName;
            }

            set
            {
                m_VictimName = value;
            }
        }

        public override DateTime DateTimeOfCreation
        {
            get
            {
                return m_CreationTime;
            }
        }
    }
}
