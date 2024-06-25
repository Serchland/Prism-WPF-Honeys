using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsConditionalBehaviourField
    {
        public FieldKey ConditionField { get; set; }
        /// <summary>
        /// Establece los valores del campo ConditionField que determinan el comportamiento del FieldBehaviour
        /// </summary>
        /// <returns></returns>
        public List<string> ConditionFieldValues { get; set; }
        /// <summary>
        /// Determina si los cambios de comportamiento afectan a la operación de creación
        /// </summary>
        /// <returns></returns>
        public bool OnCreate { get; set; }
        /// <summary>
        /// Determina si los cambios de comportamiento afectan a la operación de modificación
        /// </summary>
        /// <returns></returns>
        public bool OnUpdate { get; set; }
        /// <summary>
        /// Establece el campo destino de los cambios de comportamietno
        /// </summary>
        /// <returns></returns>
        public FieldKey BehaviourField { get; set; }
        /// <summary>
        /// Establece si el valor de IsRequired será modificado por los cambios de comportamiento
        /// </summary>
        /// <returns></returns>
        public Nullable<bool> IsRequired { get; set; }
        /// <summary>
        /// Establece si el valor  de IsEditable será modificado por los cambios de comportamiento
        /// </summary>
        /// <returns></returns>
        public Nullable<bool> IsEditable { get; set; }
        /// <summary>
        /// Establece si el campo Value será modificado por los cambios de comportamiento
        /// </summary>
        /// <returns></returns>
        public object Value { get; set; }
        /// <summary>
        /// Establece si el campo regExPattern será modificado por los cambios de comportamiento
        /// </summary>
        /// <returns></returns>
        public string RegExPattern { get; set; }
        /// <summary>
        /// Establece si el campo MaxLength será modificado por los cambios de comportamiento
        /// </summary>
        /// <returns></returns>
        public Nullable<int> MaxLength { get; set; }
    }
}
