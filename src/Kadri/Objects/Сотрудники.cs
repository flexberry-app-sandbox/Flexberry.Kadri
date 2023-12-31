﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Kadri
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Сотрудники.
    /// </summary>
    // *** Start programmer edit section *** (Сотрудники CustomAttributes)

    // *** End programmer edit section *** (Сотрудники CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СотрудникиE", new string[] {
            "ID as \'ID\'",
            "Дата_приема as \'Дата_приема\'",
            "ФИО as \'ФИО\'",
            "Контакты as \'Контакты\'",
            "Образование as \'Образование\'",
            "Опыт_работы as \'Опыт_работы\'",
            "Отдел as \'Отдел\'",
            "Отдел.Название as \'Название\'",
            "Должность as \'Должность\'",
            "Должность.Название as \'Название\'"}, Hidden=new string[] {
            "Отдел.Название",
            "Должность.Название"})]
    [MasterViewDefineAttribute("СотрудникиE", "Отдел", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    [MasterViewDefineAttribute("СотрудникиE", "Должность", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    [View("СотрудникиL", new string[] {
            "ID as \'ID\'",
            "Дата_приема as \'Дата_приема\'",
            "ФИО as \'ФИО\'",
            "Контакты as \'Контакты\'",
            "Образование as \'Образование\'",
            "Опыт_работы as \'Опыт_работы\'",
            "Отдел.Название as \'Название\'",
            "Должность.Название as \'Название\'"})]
    public class Сотрудники : ICSSoft.STORMNET.DataObject
    {
        
        private int fID;
        
        private string fФИО;
        
        private string fКонтакты;
        
        private string fОбразование;
        
        private string fОпыт_работы;
        
        private System.DateTime fДата_приема;
        
        private IIS.Kadri.Отделы fОтдел;
        
        private IIS.Kadri.Должности fДолжность;
        
        // *** Start programmer edit section *** (Сотрудники CustomMembers)

        // *** End programmer edit section *** (Сотрудники CustomMembers)

        
        /// <summary>
        /// ID.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.ID CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.ID CustomAttributes)
        public virtual int ID
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.ID Get start)

                // *** End programmer edit section *** (Сотрудники.ID Get start)
                int result = this.fID;
                // *** Start programmer edit section *** (Сотрудники.ID Get end)

                // *** End programmer edit section *** (Сотрудники.ID Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.ID Set start)

                // *** End programmer edit section *** (Сотрудники.ID Set start)
                this.fID = value;
                // *** Start programmer edit section *** (Сотрудники.ID Set end)

                // *** End programmer edit section *** (Сотрудники.ID Set end)
            }
        }
        
        /// <summary>
        /// Дата_приема.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Дата_приема CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Дата_приема CustomAttributes)
        public virtual System.DateTime Дата_приема
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Дата_приема Get start)

                // *** End programmer edit section *** (Сотрудники.Дата_приема Get start)
                System.DateTime result = this.fДата_приема;
                // *** Start programmer edit section *** (Сотрудники.Дата_приема Get end)

                // *** End programmer edit section *** (Сотрудники.Дата_приема Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Дата_приема Set start)

                // *** End programmer edit section *** (Сотрудники.Дата_приема Set start)
                this.fДата_приема = value;
                // *** Start programmer edit section *** (Сотрудники.Дата_приема Set end)

                // *** End programmer edit section *** (Сотрудники.Дата_приема Set end)
            }
        }
        
        /// <summary>
        /// Контакты.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Контакты CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Контакты CustomAttributes)
        [StrLen(255)]
        public virtual string Контакты
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Контакты Get start)

                // *** End programmer edit section *** (Сотрудники.Контакты Get start)
                string result = this.fКонтакты;
                // *** Start programmer edit section *** (Сотрудники.Контакты Get end)

                // *** End programmer edit section *** (Сотрудники.Контакты Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Контакты Set start)

                // *** End programmer edit section *** (Сотрудники.Контакты Set start)
                this.fКонтакты = value;
                // *** Start programmer edit section *** (Сотрудники.Контакты Set end)

                // *** End programmer edit section *** (Сотрудники.Контакты Set end)
            }
        }
        
        /// <summary>
        /// Образование.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Образование CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Образование CustomAttributes)
        [StrLen(255)]
        public virtual string Образование
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Образование Get start)

                // *** End programmer edit section *** (Сотрудники.Образование Get start)
                string result = this.fОбразование;
                // *** Start programmer edit section *** (Сотрудники.Образование Get end)

                // *** End programmer edit section *** (Сотрудники.Образование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Образование Set start)

                // *** End programmer edit section *** (Сотрудники.Образование Set start)
                this.fОбразование = value;
                // *** Start programmer edit section *** (Сотрудники.Образование Set end)

                // *** End programmer edit section *** (Сотрудники.Образование Set end)
            }
        }
        
        /// <summary>
        /// Опыт_работы.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Опыт_работы CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Опыт_работы CustomAttributes)
        [StrLen(255)]
        public virtual string Опыт_работы
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Опыт_работы Get start)

                // *** End programmer edit section *** (Сотрудники.Опыт_работы Get start)
                string result = this.fОпыт_работы;
                // *** Start programmer edit section *** (Сотрудники.Опыт_работы Get end)

                // *** End programmer edit section *** (Сотрудники.Опыт_работы Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Опыт_работы Set start)

                // *** End programmer edit section *** (Сотрудники.Опыт_работы Set start)
                this.fОпыт_работы = value;
                // *** Start programmer edit section *** (Сотрудники.Опыт_работы Set end)

                // *** End programmer edit section *** (Сотрудники.Опыт_работы Set end)
            }
        }
        
        /// <summary>
        /// ФИО.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.ФИО CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.ФИО CustomAttributes)
        [StrLen(255)]
        public virtual string ФИО
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.ФИО Get start)

                // *** End programmer edit section *** (Сотрудники.ФИО Get start)
                string result = this.fФИО;
                // *** Start programmer edit section *** (Сотрудники.ФИО Get end)

                // *** End programmer edit section *** (Сотрудники.ФИО Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.ФИО Set start)

                // *** End programmer edit section *** (Сотрудники.ФИО Set start)
                this.fФИО = value;
                // *** Start programmer edit section *** (Сотрудники.ФИО Set end)

                // *** End programmer edit section *** (Сотрудники.ФИО Set end)
            }
        }
        
        /// <summary>
        /// Сотрудники.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Должность CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Должность CustomAttributes)
        [PropertyStorage(new string[] {
                "Должность"})]
        [NotNull()]
        public virtual IIS.Kadri.Должности Должность
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Должность Get start)

                // *** End programmer edit section *** (Сотрудники.Должность Get start)
                IIS.Kadri.Должности result = this.fДолжность;
                // *** Start programmer edit section *** (Сотрудники.Должность Get end)

                // *** End programmer edit section *** (Сотрудники.Должность Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Должность Set start)

                // *** End programmer edit section *** (Сотрудники.Должность Set start)
                this.fДолжность = value;
                // *** Start programmer edit section *** (Сотрудники.Должность Set end)

                // *** End programmer edit section *** (Сотрудники.Должность Set end)
            }
        }
        
        /// <summary>
        /// Сотрудники.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Отдел CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Отдел CustomAttributes)
        [PropertyStorage(new string[] {
                "Отдел"})]
        [NotNull()]
        public virtual IIS.Kadri.Отделы Отдел
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Отдел Get start)

                // *** End programmer edit section *** (Сотрудники.Отдел Get start)
                IIS.Kadri.Отделы result = this.fОтдел;
                // *** Start programmer edit section *** (Сотрудники.Отдел Get end)

                // *** End programmer edit section *** (Сотрудники.Отдел Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Отдел Set start)

                // *** End programmer edit section *** (Сотрудники.Отдел Set start)
                this.fОтдел = value;
                // *** Start programmer edit section *** (Сотрудники.Отдел Set end)

                // *** End programmer edit section *** (Сотрудники.Отдел Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СотрудникиE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникиE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникиE", typeof(IIS.Kadri.Сотрудники));
                }
            }
            
            /// <summary>
            /// "СотрудникиL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникиL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникиL", typeof(IIS.Kadri.Сотрудники));
                }
            }
        }
    }
}
