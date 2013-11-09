namespace DicePlus
{
	public enum DPAccelerometerFilter {
		Raw = 1,
		LowPass = 2,
		HighPass = 4
	}

	public enum DPMagnetometerFilter {
		Raw = 1,
		LowPass = 2
	}

	public enum DPDieMode {
		LedsOn = 0,
		LedsOff = 1
	}

	public enum DPSensor {
		Roll = 1,
		Magnetometer = 2,
		Accelerometer = 3,
		Thermometer = 4,
		Touch = 5,
		Proximity = 6,
		Orientation = 9,
		LedState = 10,
		PowerMode = 11,
		Battery = 13,
		FaceChange = 15,
		Tap = 16
	}

	public enum DPCharacteristic {
		MagnetometerConfig = 2,
		AccelerometerConfig = 3,
		ProximityConfig = 6,
		GyroscopeConfig = 8,
		OrientationConfig = 9,
		PowerMode = 11,
		Statistics = 14
	}

	public enum DPDieAnimation {
		Clear = 0,
		RollOK = 4
	}

	public enum DPRollFlag {
		OK = 0,
		Tilt = 1,
		TooShort = 2
	}

	public enum DPPersistentStorageValueType {
		Int = 1,
		Vector = 2,
		String = 3
	}

	public enum DPPersistentStorageDescriptorFlags {
		Read = 1,
		Write = 2,
		DefaultValue = 4,
		MinValue = 8,
		MaxValue = 16
	}

	public enum DPMode {
		Operating = 0,
		GoingToSleep = 1,
		Sleeping = 2
	}

	public enum DPLedStateType {
		Finish = 1,
		UserSpace = 2
	}
}

