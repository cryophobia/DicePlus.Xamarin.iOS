using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.CoreBluetooth;

namespace DicePlus {


	[BaseType (typeof (NSObject))]
	public interface DPRoll {

		[Export ("timestamp")]
		int Timestamp { get; set; }

		[Export ("duration")]
		int Duration { get; set; }

		[Export ("flags")]
		int Flags { get; set; }

		[Export ("result")]
		int Result { get; set; }
	}


	[BaseType (typeof (NSObject))]
	public interface DPDie {

		[Export ("delegate", ArgumentSemantic.Assign)]
		DPDieDelegate Delegate { get; set; }

		[Export ("persistentStorageDescriptors", ArgumentSemantic.Retain)]
		NSObject[] PersistentStorageDescriptors { get; set; }

		[Export ("peripheral", ArgumentSemantic.Retain)]
		CBPeripheral Peripheral { get; set; }

		[Export ("systemStatus")]
		NSNumber SystemStatus { get; set; }

		[Export ("UID")]
		string UID { get; set; }

		[Export ("name")]
		string Name { get; set; }

		[Export ("RSSI", ArgumentSemantic.Retain)]
		NSNumber RSSI { get; set; }

		[Export ("UUID")]
		CBUUID UUID { get; set; }

		[Export ("softwareVersion")]
		DPSoftwareVersion SoftwareVersion { get; set; }

		[Export ("hardwareVersion")]
		DPHardwareVersion HardwareVersion { get; set; }

		[Export ("modelNumber")]
		int ModelNumber { get; set; }

		[Export ("faceCount")]
		NSNumber FaceCount { get; set; }

		[Export ("ledCount")]
		NSNumber LedCount { get; set; }

		[Export ("isConnected")]
		bool IsConnected {get; set; }

		[Export ("initWithPeripheral:")]
		IntPtr Constructor (CBPeripheral peripheral);

		[Export ("dieDisconnected")]
		 void DieDisconnected ();

		[Export ("mode")]
		DPDieMode Mode { get; set; }

		[Export ("sleep")]
		 void Sleep ();

		[Export ("startBlinkAnimationWithMask:priority:r:g:b:onPeriod:cyclePeriod:blinkCount:")]
		 void StartBlinkAnimationWithMask (int ledMask, int priority, int r, int g, int b, int onPeriod, int cyclePeriod, int blinkCount);

		[Export ("startFadeAnimationWithMask:priority:r:g:b:fadeTime:pauseTime:")]
		 void StartFadeAnimationWithMask (int ledMask, int priority, int r, int g, int b, int fadeTime, int pauseTime);

		[Export ("startFadeAnimationWithMask:priority:r:g:b:fadeTime:pauseTime:repeatCount:")]
		 void StartFadeAnimationWithMask (int ledMask, int priority, int r, int g, int b, int fadeTime, int pauseTime, int repeatCount);

		[Export ("startStandardAnimationWithMask:priority:animation:")]
		 void StartStandardAnimationWithMask (int ledMask, int priority, DPDieAnimation animation);

		[Export ("readLedState")]
		 void ReadLedState ();

		[Export ("startLedStateUpdates")]
		 void StartLedStateUpdates ();

		[Export ("stopLedStateUpdates")]
		 void StopLedStateUpdates ();

		[Export ("startRollUpdates")]
		 void StartRollUpdates ();

		[Export ("stopRollUpdates")]
		 void StopRollUpdates ();

		[Export ("startMagnetometerUpdates")]
		 void StartMagnetometerUpdates ();

		[Export ("startMagnetometerUpdatesWithFrequency:andFilter:")]
		 void StartMagnetometerUpdatesWithFrequency (int frequency, int filter);

		[Export ("stopMagnetometerUpdates")]
		 void StopMagnetometerUpdates ();

		[Export ("startAccelerometerUpdates")]
		 void StartAccelerometerUpdates ();

		[Export ("startAccelerometerUpdatesWithFrequency:andFilter:")]
		 void StartAccelerometerUpdatesWithFrequency (int frequency, int filter);

		[Export ("stopAccelerometerUpdates")]
		 void StopAccelerometerUpdates ();

		[Export ("startThermometerUpdates")]
		 void StartThermometerUpdates ();

		[Export ("stopThermometerUpdates")]
		 void StopThermometerUpdates ();

		[Export ("startTouchUpdates")]
		 void StartTouchUpdates ();

		[Export ("stopTouchUpdates")]
		 void StopTouchUpdates ();

		[Export ("startProximityUpdates")]
		 void StartProximityUpdates ();

		[Export ("startProximityUpdatesWithFrequency:")]
		 void StartProximityUpdatesWithFrequency (int frequency);

		[Export ("stopProximityUpdates")]
		 void StopProximityUpdates ();

		[Export ("startOrientationUpdates")]
		 void StartOrientationUpdates ();

		[Export ("startOrientationUpdatesWithFrequency:")]
		 void StartOrientationUpdatesWithFrequency (int frequency);

		[Export ("stopOrientationUpdates")]
		 void StopOrientationUpdates ();

		[Export ("startBatteryUpdates")]
		 void StartBatteryUpdates ();

		[Export ("stopBatteryUpdates")]
		 void StopBatteryUpdates ();

		[Export ("startPowerModeUpdates")]
		 void StartPowerModeUpdates ();

		[Export ("stopPowerModeUpdates")]
		 void StopPowerModeUpdates ();

		[Export ("startTapUpdates")]
		 void StartTapUpdates ();

		[Export ("stopTapUpdates")]
		 void StopTapUpdates ();

		[Export ("startFaceChangeUpdates")]
		 void StartFaceChangeUpdates ();

		[Export ("stopFaceChangeUpdates")]
		 void StopFaceChangeUpdates ();

		[Export ("readStatistics")]
		 void ReadStatistics ();

		[Export ("initializePersistentStorageCommunication")]
		 void InitializePersistentStorageCommunication ();

		[Export ("resetPersistentStorage")]
		 void ResetPersistentStorage ();

		[Export ("readPersistentStorageValueForHandle:")]
		 void ReadPersistentStorageValueForHandle (int handle);

		[Export ("writePersistentIntValue:forHandle:")]
		 void WritePersistentIntValue (int value, int handle);

		[Export ("writePersistentStringValue:forHandle:")]
		 void WritePersistentStringValue (string value, int handle);

		[Export ("writePersistentVectorValueWithX:y:andZ:forHandle:")]
		 void WritePersistentVectorValueWithX (int x, int y, int z, int handle);
	}


	[BaseType (typeof (NSObject))]
	public partial interface DPAcceleration {

		[Export ("timestamp")]
		uint Timestamp { get; set; }

		[Export ("filter")]
		DPAccelerometerFilter Filter { get; set; }

		[Export ("x")]
		int X { get; set; }

		[Export ("y")]
		int Y { get; set; }

		[Export ("z")]
		int Z { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface DPSoftwareVersion {

		[Export ("initWithMajor:minor:andBuild:")]
		IntPtr Constructor (uint major, uint minor, uint build);

		[Export ("major")]
		uint Major { get; }

		[Export ("minor")]
		uint Minor { get; }

		[Export ("build")]
		uint Build { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface DPHardwareVersion {

		[Export ("initWithMajor:andMinor:")]
		IntPtr Constructor (uint major, uint minor);

		[Export ("major")]
		uint Major { get; }

		[Export ("minor")]
		uint Minor { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface DPDiceManager {

		[Static, Export ("sharedDiceManager")]
		DPDiceManager SharedDiceManager { get; set;}

		[Export ("delegate", ArgumentSemantic.Assign)]
		DPDiceManagerDelegate Delegate { get; set; }

		[Export ("key")]
		IntPtr Key { set; }

		[Export ("startScan")]
		 void StartScan ();

		[Export ("stopScan")]
		 void StopScan ();

		[Export ("connectDie:")]
		 void ConnectDie (DPDie die);

		[Export ("disconnectDie:")]
		 void DisconnectDie (DPDie die);

		[Export ("disconnectAllDice")]
		 void DisconnectAllDice ();
	}



	[Model, BaseType (typeof (NSObject))]
	public interface DPDiceManagerDelegate  {

		[Export ("centralManagerDidUpdateState:")]
		void UpdateState (CBCentralManagerState state);

		[Export ("diceManager:didDiscoverDie:")]
		void DidDiscoverDie (DPDiceManager manager, DPDie die);

		[Export ("diceManager:didConnectDie:")]
		void DidConnectDie (DPDiceManager manager, DPDie die);

		[Export ("diceManager:didDisconnectDie:error:")]
		void DidDisconnectDie (DPDiceManager manager, DPDie die, NSError error);

		[Export ("diceManager:failedConnectingDie:error:")]
		void FailedConnectingDie (DPDiceManager manager, DPDie die, NSError error);

		[Export ("diceManagerStoppedScan:")]
		void StoppedScan (DPDiceManager manager);
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface DPDieDelegate {

		[Export ("dieConnected:")]
		void DieConnected (DPDie die);

		[Export ("die:didUpdateNotificationStateForSensor:withError:")]
		void DidUpdateNotificationStateForSensor (DPDie die, DPSensor sensor, NSError error);

		[Export ("die:didChangeChargingState:error:")]
		void DidChangeChargingState (DPDie die, bool isCharging, NSError error);

		[Export ("die:didChangeLedState:error:")]
		void DidChangeLedState (DPDie die, DPLedState status, NSError error);

		[Export ("die:didRoll:error:")]
		void DidRoll (DPDie die, DPRoll roll, NSError error);

		[Export ("die:didAccelerate:error:")]
		void DidAccelerate (DPDie die, DPAcceleration acceleration, NSError error);

		[Export ("die:didUpdateMagnetometer:error:")]
		void DidUpdateMagnetometer (DPDie die, DPMagnetometer data, NSError error);

		[Export ("die:didUpdateOrientation:error:")]
		void DidUpdateOrientation (DPDie die, DPOrientation orientation, NSError error);

		[Export ("die:didUpdateTemperature:error:")]
		void DidUpdateTemperature (DPDie die, DPTemperature temperature, NSError error);

		[Export ("die:didUpdateProximity:error:")]
		void DidUpdateProximity (DPDie die, DPProximity proximity, NSError error);

		[Export ("die:didUpdateTouches:error:")]
		void DidUpdateTouches (DPDie die, DPTouch touch, NSError error);

		[Export ("die:didReceiveStatistics:error:")]
		void DidReceiveStatistics (DPDie die, DPStatistics statistics, NSError error);

		[Export ("die:didUpdatePowerMode:error:")]
		void DidUpdatePowerMode (DPDie die, DPPowerMode mode, NSError error);

		[Export ("die:didUpdateBatteryStatus:error:")]
		void DidUpdateBatteryStatus (DPDie die, DPBattery status, NSError error);

		[Export ("die:didTap:error:")]
		void DidTap (DPDie die, DPTap tap, NSError error);

		[Export ("die:didChangeFace:error:")]
		void DidChangeFace (DPDie die, DPFaceChange faceChange, NSError error);

		[Export ("die:startedAnimation:")]
		void StartedAnimation (DPDie die, NSError error);

		[Export ("die:failedToStartUpdatesForSensor:withError:")]
		void FailedToStartUpdatesForSensor (DPDie die, DPSensor sensor, NSError error);

		[Export ("die:failedToStopUpdatesForSensor:withError:")]
		void FailedToStopUpdatesForSensor (DPDie die, DPSensor sensor, NSError error);

		[Export ("die:didFinishSleepRequest:")]
		void DidFinishSleepRequest (DPDie die, NSError error);

		[Export ("die:didFinishSetModeRequest:")]
		void DidFinishSetModeRequest (DPDie die, NSError error);

		[Export ("die:didInitializePersistenStorage:error:")]
		void DidInitializePersistenStorage (DPDie die, NSObject [] descriptors, NSError error);

		[Export ("dieDidResetPersistentStorage:error:")]
		void Error (DPDie die, NSError error);

		[Export ("die:didReadPersistentValue:forHandle:error:")]
		void DidReadPersistentValue (DPDie die, NSObject value, int handle, NSError error);

		[Export ("die:didWritePersistentValueForHandle:error:")]
		void DidWritePersistentValueForHandle (DPDie die, int handle, NSError error);

		[Export ("die:didFinishPersistentStorageOperation:")]
		void DidFinishPersistentStorageOperation (DPDie die, NSError error);
	}

	[BaseType (typeof (NSObject))]
	public partial interface DPMagnetometer {

		[Export ("timestamp")]
		uint Timestamp { get; set; }

		[Export ("filter")]
		DPMagnetometerFilter Filter { get; set; }

		[Export ("x")]
		int X { get; set; }

		[Export ("y")]
		int Y { get; set; }

		[Export ("z")]
		int Z { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface DPOrientation {

		[Export ("timestamp")]
		uint Timestamp { get; set; }

		[Export ("roll")]
		int Roll { get; set; }

		[Export ("pitch")]
		int Pitch { get; set; }

		[Export ("yaw")]
		int Yaw { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface DPTemperature {

		[Export ("timestamp")]
		uint Timestamp { get; set; }

		[Export ("temperature")]
		float Temperature { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface DPProximity {

		[Export ("timestamp")]
		uint Timestamp { get; set; }

		[Export ("values", ArgumentSemantic.Retain)]
		NSObject [] Values { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface DPTouch {

		[Export ("timestamp")]
		uint Timestamp { get; set; }

		[Export ("changeMask")]
		uint ChangeMask { get; set; }

		[Export ("currentStateMask")]
		uint CurrentStateMask { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface DPStatistics {

		[Export ("totalRolls")]
		int TotalRolls { get; set; }

		[Export ("validRolls")]
		int ValidRolls { get; set; }

				[Export ("rolls", ArgumentSemantic.Retain)]
		NSObject [] Rolls { get; set; }

		[Export ("connectedTime")]
		int ConnectedTime { get; set; }

		[Export ("timesAuthenticated")]
		int TimesAuthenticated { get; set; }

		[Export ("rollTime")]
		int RollTime { get; set; }

		[Export ("chargingCycles")]
		int ChargingCycles { get; set; }

		[Export ("chargingTime")]
		int ChargingTime { get; set; }

		[Export ("wakeupCount")]
		int WakeupCount { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface DPLedState {

		[Export ("timestamp")]
		uint Timestamp { get; set; }

		[Export ("animationId")]
		uint AnimationId { get; set; }

		[Export ("mask")]
		int Mask { get; set; }

		[Export ("type")]
		int Type { get; set; }

		[Export ("isFinished")]
		bool IsFinished { get; }

		[Export ("isUserAnimation")]
		bool IsUserAnimation { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface DPPowerMode {

		[Export ("timestamp")]
		uint Timestamp { get; set; }

		[Export ("mode")]
		uint Mode { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface DPTap {

		[Export ("timestamp")]
		uint Timestamp { get; set; }

		[Export ("x")]
		int X { get; set; }

		[Export ("y")]
		int Y { get; set; }

		[Export ("z")]
		int Z { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface DPFaceChange {

		[Export ("timestamp")]
		uint Timestamp { get; set; }

		[Export ("face")]
		int Face { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface DPBattery {

		[Export ("level")]
		int Level { get; set; }

		[Export ("isCharging")]
		bool IsCharging { get; set; }

		[Export ("isLow")]
		bool IsLow { get; set; }
	}
}
