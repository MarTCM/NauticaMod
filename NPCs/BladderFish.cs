using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace NauticaMod.NPCs
{
    public class BladderFish : ModNPC
    {       

        public override void SetStaticDefaults() 
        {
			Main.npcFrameCount[npc.type] = 7;
	    }
        public override void SetDefaults()
        {
            npc.width = 44;
			npc.height = 46;
			npc.aiStyle = 16;
			//npc.damage = 30;
			//npc.defense = 3;
			npc.lifeMax = 30;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			//npc.alpha = 175;
			//npc.color = new Color(0, 80, 255, 100);
			npc.buffImmune[BuffID.Poisoned] = false;
			npc.buffImmune[BuffID.Confused] = false; 
            npc.noGravity = true;        
            npc.noTileCollide = false; 
            aiType = NPCID.Goldfish;  //npc behavior
            animationType = NPCID.Goldfish;
            npc.knockBackResist = 0.0f;
        }

        public override void NPCLoot()  //Npc drop
        {
            if (Main.rand.NextFloat() < .7500f)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BladderFish"), 1);
                }

        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OceanMonster.Chance * 0.3f;
        }
    }
}