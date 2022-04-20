using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class Task
    {
        ///<summary>
        ///Название задачи
        ///</summary>
    public string Title { get; set; }
        ///<summary>
        ///Дата и время завершение выполнения
        /// </summary> 
     public DateTime Due { get; set; }
    }
}
