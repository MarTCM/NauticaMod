using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NauticaMod.NPCs
{
    public class Stalker : ModNPC
    {       
        public override void SetStaticDefaults() 
        {
			Main.npcFrameCount[npc.type] = 6;
	    }
        public override void SetDefaults()
        {
            npc.width = 200;
			npc.height = 66;
			npc.aiStyle = 16;
			npc.damage = 50;
			npc.defense = 2;
			npc.lifeMax = 350;
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
            npc.knockBackResist = 0.6f;
        }

        public override void NPCLoot()  //Npc drop
        {
            {
                if (Main.rand.NextFloat() < .2500f)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MetalSalvage"), 1);
                }
            }

        }
        
    }
}