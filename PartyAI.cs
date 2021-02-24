using System;
using System.IO;
using System.Collections.Generic;
//using Microsoft.Office.Interop.Excel;



namespace Final_Gambit_Player_Code
{

    static public class PartyAI
    {

        static public void ProcessAI()
        {

            ///Console.WriteLine("asdfgfwegwersgwerhgerwaghwererhghgrew");


            #region SampleCode

            PartyCharacter target = null;

            if (FinalGambit.BattleState.characterWithInitiative.classID == FinalGambit.CharacterClassID.Fighter)
            {
                //The character with initiative is a figher, do something here...

                Console.WriteLine("this is a fighter");

            }
            else if (FinalGambit.BattleState.characterWithInitiative.classID == FinalGambit.CharacterClassID.Cleric)
            {
                //The character with initiative is a figher, do something here...

                Console.WriteLine("this is a cleric");

                int hurtAllies = 0;

                //Battle tactic 1
                foreach (PartyCharacter pc in FinalGambit.BattleState.partyCharacters)//detect all allies
                {
                    if (pc.hp > 0) {
                        if (pc.hp < pc.maxHP * 0.75f)
                            hurtAllies++;

                        if (hurtAllies >= 2)
                        {
                            FinalGambit.PerformBattleAction(FinalGambit.BattleActionID.Bubble, pc);
                            return;
                        }
                    }
                }

                //Battle tactic 2
                foreach (PartyCharacter pc in FinalGambit.BattleState.partyCharacters)// detects all allies
                {
                    if (pc.hp > 0)
                    {
                        if(pc.hp < pc.maxHP * 0.25f)
                        {
                            if(target == null)
                            {
                                switch (pc.classID)
                                {
                                    case FinalGambit.CharacterClassID.Cleric:
                                        target = pc;
                                        break;
                                    case FinalGambit.CharacterClassID.Monk:
                                        target = pc;
                                        break;
                                    case FinalGambit.CharacterClassID.Wizard:
                                        target = pc;
                                        break;

                                }
                            }
                            FinalGambit.PerformBattleAction
                        }
                    }
                }
            }
            else if (FinalGambit.BattleState.characterWithInitiative.classID == FinalGambit.CharacterClassID.Wizard)
            {
                //The character with initiative is a figher, do something here...

                Console.WriteLine("this is a wizard");

            }



            PartyCharacter target = null;

            foreach (PartyCharacter pc in FinalGambit.BattleState.foeCharacters)
            {
                if (pc.hp > 0)
                {
                    if (target == null)
                        target = pc;
                    else if (pc.hp < target.hp)
                        target = pc;
                }
            }

            FinalGambit.PerformBattleAction(FinalGambit.BattleActionID.Attack, target);




            //Console.WriteLine("Char with init: " + FinalGambit.characterWithInitiative);





            foreach (PartyCharacter pc in FinalGambit.BattleState.partyCharacters)
            {
                foreach (StatusEffect se in pc.statusEffects)
                {
                    if (se.id == FinalGambit.StatusEffectID.Poison)
                    {
                        //We have found a character that is poisoned, do something here...
                    }
                }
            }







            #endregion

        }


    }

}




