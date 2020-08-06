using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NauticaMod.NPCs
{
    public class Symbiote : ModNPC
    {       
        public override void SetStaticDefaults() 
        {
			Main.npcFrameCount[npc.type] = 4;
	    }
        public override void SetDefaults()
        {
            npc.width = 45;
			npc.height = 23;
			npc.aiStyle = 16;
			npc.damage = 30;
			npc.defense = 3;
			npc.lifeMax = 30;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			//npc.alpha = 175;
			//npc.color = new Color(0, 80, 255, 100);
			npc.buffImmune[BuffID.Poisoned] = false;
			npc.buffImmune[BuffID.Confused] = false; 
            npc.noGravity = true;        
            npc.noTileCollide = false; 
            aiType = NPCID.Shark;  //npc behavior
            animationType = NPCID.Shark;
            npc.knockBackResist = 0.0f;
        }

        public override void NPCLoot()  //Npc drop
        {
            {
                //Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Starshark"), 1); //Item spawn
            }

        }
        
    }
}