using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace DicePlus.Test
{
	public partial class DicePlus_TestViewController : UIViewController
	{
		public DicePlus_TestViewController () : base ("DicePlus_TestViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			byte[] key = {0x83, 0xed, 0x60, 0x0e, 0x5d, 0x31, 0x8f, 0xe7};

			var diceManager = DPDiceManager.SharedDiceManager;
			diceManager.Delegate = new DiceMangerDelegate();
			DicePlusHelper.SetKey(key, diceManager);

			diceManager.StartScan();
		}

		class DiceMangerDelegate : DPDiceManagerDelegate{
			DPDie _dice;

			public override void UpdateState (MonoTouch.CoreBluetooth.CBCentralManagerState state)
			{
				Console.WriteLine(state);
			}

			public override void DidDiscoverDie (DPDiceManager manager, DPDie die)
			{
				_dice = die;
				_dice.Delegate = new DiceDelegate();

				manager.StopScan();
				manager.ConnectDie(_dice);
				Console.WriteLine("Did discover die {0}...", die.UID);
			}

			public override void DidConnectDie (DPDiceManager manager, DPDie die)
			{
				Console.WriteLine("Did connect die: {0} ...", die.UID);
			}

			public override void DidDisconnectDie (DPDiceManager manager, DPDie die, NSError error)
			{
				Console.WriteLine("Did disconnect die: {0} ...", die.UID);
			}

			public override void FailedConnectingDie (DPDiceManager manager, DPDie die, NSError error)
			{
				Console.WriteLine("Failed connecting die: {0} ...", error.Code);
				manager.StartScan();
			}
		}

		class DiceDelegate : DPDieDelegate{
			public override void DieConnected (DPDie die)
			{
				die.StartRollUpdates();
			}

			public override void DidRoll (DPDie die, DPRoll roll, NSError error)
			{
				if (roll.Flags == (int)DPRollFlag.OK){
					Console.WriteLine("Good roll: {0}", roll.Result);
				}
			}
		}
	}
}

