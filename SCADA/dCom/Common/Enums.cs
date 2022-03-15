﻿namespace Common
{
    /// <summary>
    /// Digital states.
    /// </summary>
	public enum DState : short
	{
		OFF = 0,
		ON = 1,
	}

    /// <summary>
    /// Modbus Function codes for reading and writing modbus points.
    /// </summary>
	public enum ModbusFunctionCode : short
	{
		READ_COILS = 0x01,
		READ_DISCRETE_INPUTS = 0x02,
		READ_HOLDING_REGISTERS = 0x03,
		READ_INPUT_REGISTERS = 0x04,
		WRITE_SINGLE_COIL = 0x05,
		WRITE_SINGLE_REGISTER = 0x06,
	}

    /// <summary>
    /// Possible modbus point types.
    /// </summary>
	public enum PointType : short
	{
		DIGITAL_OUTPUT = 0x01,
		DIGITAL_INPUT = 0x02,
		ANALOG_INPUT = 0x03,
		ANALOG_OUTPUT = 0x04,
		HR_LONG = 0x05,
	}

    /// <summary>
    /// Connection states.
    /// </summary>
	public enum ConnectionState : short
	{
		CONNECTED = 0,
		DISCONNECTED = 1,
	}

    /// <summary>
    /// Alarm types.
    /// </summary>
	public enum AlarmType : short
	{
		NO_ALARM = 0x01,
		REASONABILITY_FAILURE = 0x02,
        LOW_ALARM = 0x03,
        HIGH_ALARM = 0x04,
        ABNORMAL_VALUE = 0x05,
	}
}