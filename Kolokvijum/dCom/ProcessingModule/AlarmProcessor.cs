using Common;

namespace ProcessingModule
{
    /// <summary>
    /// Class containing logic for alarm processing.
    /// </summary>
    public class AlarmProcessor
	{
        /// <summary>
        /// Processes the alarm for analog point.
        /// </summary>
        /// <param name="eguValue">The EGU value of the point.</param>
        /// <param name="configItem">The configuration item.</param>
        /// <returns>The alarm indication.</returns>
		public AlarmType GetAlarmForAnalogPoint(double eguValue, IConfigItem configItem)
		{
            if (eguValue < configItem.EGU_Min || eguValue > configItem.EGU_Max)
                return AlarmType.REASONABILITY_FAILURE;
            else if (eguValue <= configItem.LowLimit)
                return AlarmType.LOW_ALARM;
            else if (eguValue >= configItem.HighLimit)
                return AlarmType.HIGH_ALARM;
			return AlarmType.NO_ALARM;
		}

        /// <summary>
        /// Processes the alarm for digital point.
        /// </summary>
        /// <param name="state">The digital point state</param>
        /// <param name="configItem">The configuration item.</param>
        /// <returns>The alarm indication.</returns>
		public AlarmType GetAlarmForDigitalPoint(ushort state, IConfigItem configItem)
		{
            if (state == configItem.AbnormalValue)
                return AlarmType.ABNORMAL_VALUE;
            return AlarmType.NO_ALARM;
        }
	}
}
