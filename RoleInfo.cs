using HarmonyLib;
using System.Linq;
using System;
using System.Collections.Generic;
using static TheOtherRoles.TheOtherRoles;
using static TheOtherRoles.TheOtherRolesGM;
using UnityEngine;

namespace TheOtherRoles
{
    class RoleInfo {
        public Color color;
        public virtual string name { get { return ModTranslation.getString(nameKey); } }
        public virtual string nameColored { get { return Helpers.cs(color, name); } }
        public virtual string introDescription { get { return ModTranslation.getString(nameKey + "IntroDesc"); } }
        public virtual string shortDescription { get { return ModTranslation.getString(nameKey + "ShortDesc"); } }
        public virtual string fullDescription { get { return ModTranslation.getString(nameKey + "FullDesc"); } }
        public virtual string blurb { get { return ModTranslation.getString(nameKey + "Blurb"); } }
        public virtual string roleOptions
        {
            get
            {
                return GameOptionsDataPatch.optionsToString(baseOption, true);
            }
        }
        public bool enabled { get { return baseOption == null || baseOption.enabled; } }
        public RoleType roleId;

        private string nameKey;
        private CustomOption baseOption;

        RoleInfo(string name, Color color, CustomOption baseOption, RoleType roleId) {
            this.color = color;
            this.nameKey = name;
            this.baseOption = baseOption;
            this.roleId = roleId;
        }

        public static RoleInfo jester = new RoleInfo("小丑", Jester.color, CustomOptionHolder.jesterSpawnRate, RoleType.Jester);
        public static RoleInfo mayor = new RoleInfo("市长", Mayor.color, CustomOptionHolder.mayorSpawnRate, RoleType.Mayor);
        public static RoleInfo engineer = new RoleInfo("工程师", Engineer.color, CustomOptionHolder.engineerSpawnRate, RoleType.Engineer);
        public static RoleInfo sheriff = new RoleInfo("警长", Sheriff.color, CustomOptionHolder.sheriffSpawnRate, RoleType.Sheriff);
        public static RoleInfo lighter = new RoleInfo("执灯人", Lighter.color, CustomOptionHolder.lighterSpawnRate, RoleType.Lighter);
        public static RoleInfo godfather = new RoleInfo("教父", Godfather.color, CustomOptionHolder.mafiaSpawnRate, RoleType.Godfather);
        public static RoleInfo mafioso = new RoleInfo("小弟", Mafioso.color, CustomOptionHolder.mafiaSpawnRate, RoleType.Mafioso);
        public static RoleInfo janitor = new RoleInfo("清洁工", Janitor.color, CustomOptionHolder.mafiaSpawnRate, RoleType.Janitor);
        public static RoleInfo morphling = new RoleInfo("化形者", Morphling.color, CustomOptionHolder.morphlingSpawnRate, RoleType.Morphling);
        public static RoleInfo camouflager = new RoleInfo("隐蔽者", Camouflager.color, CustomOptionHolder.camouflagerSpawnRate, RoleType.Camouflager);
        public static RoleInfo vampire = new RoleInfo("吸血鬼", Vampire.color, CustomOptionHolder.vampireSpawnRate, RoleType.Vampire);
        public static RoleInfo eraser = new RoleInfo("抹除者", Eraser.color, CustomOptionHolder.eraserSpawnRate, RoleType.Eraser);
        public static RoleInfo trickster = new RoleInfo("骗术师", Trickster.color, CustomOptionHolder.tricksterSpawnRate, RoleType.Trickster);
        public static RoleInfo cleaner = new RoleInfo("清理者", Cleaner.color, CustomOptionHolder.cleanerSpawnRate, RoleType.Cleaner);
        public static RoleInfo warlock = new RoleInfo("术士", Warlock.color, CustomOptionHolder.warlockSpawnRate, RoleType.Warlock);
        public static RoleInfo bountyHunter = new RoleInfo("赏金猎人", BountyHunter.color, CustomOptionHolder.bountyHunterSpawnRate, RoleType.BountyHunter);
        public static RoleInfo detective = new RoleInfo("侦探", Detective.color, CustomOptionHolder.detectiveSpawnRate, RoleType.Detective);
        public static RoleInfo timeMaster = new RoleInfo("时间之主", TimeMaster.color, CustomOptionHolder.timeMasterSpawnRate, RoleType.TimeMaster);
        public static RoleInfo medic = new RoleInfo("医生", Medic.color, CustomOptionHolder.medicSpawnRate, RoleType.Medic);
        public static RoleInfo niceShifter = new RoleInfo("正义的交换师", Shifter.color, CustomOptionHolder.shifterSpawnRate, RoleType.Shifter);
        public static RoleInfo corruptedShifter = new RoleInfo("中立交换师", Shifter.color, CustomOptionHolder.shifterSpawnRate, RoleType.Shifter);
        public static RoleInfo niceSwapper = new RoleInfo("正义的换票师", Swapper.color, CustomOptionHolder.swapperSpawnRate, RoleType.Swapper);
        public static RoleInfo evilSwapper = new RoleInfo("邪恶的换票师", Palette.ImpostorRed, CustomOptionHolder.swapperSpawnRate, RoleType.Swapper);
        public static RoleInfo seer = new RoleInfo("灵媒", Seer.color, CustomOptionHolder.seerSpawnRate, RoleType.Seer);
        public static RoleInfo hacker = new RoleInfo("黑客", Hacker.color, CustomOptionHolder.hackerSpawnRate, RoleType.Hacker);
        public static RoleInfo niceMini = new RoleInfo("好迷你船员", Mini.color, CustomOptionHolder.miniSpawnRate, RoleType.Mini);
        public static RoleInfo evilMini = new RoleInfo("坏迷你船员", Palette.ImpostorRed, CustomOptionHolder.miniSpawnRate, RoleType.Mini);
        public static RoleInfo tracker = new RoleInfo("追踪者", Tracker.color, CustomOptionHolder.trackerSpawnRate, RoleType.Tracker);
        public static RoleInfo snitch = new RoleInfo("告密者", Snitch.color, CustomOptionHolder.snitchSpawnRate, RoleType.Snitch);
        public static RoleInfo jackal = new RoleInfo("豺狼", Jackal.color, CustomOptionHolder.jackalSpawnRate, RoleType.Jackal);
        public static RoleInfo sidekick = new RoleInfo("跟班", Sidekick.color, CustomOptionHolder.jackalSpawnRate, RoleType.Sidekick);
        public static RoleInfo spy = new RoleInfo("卧底", Spy.color, CustomOptionHolder.spySpawnRate, RoleType.Spy);
        public static RoleInfo securityGuard = new RoleInfo("保安", SecurityGuard.color, CustomOptionHolder.securityGuardSpawnRate, RoleType.SecurityGuard);
        public static RoleInfo arsonist = new RoleInfo("纵火犯", Arsonist.color, CustomOptionHolder.arsonistSpawnRate, RoleType.Arsonist);
        public static RoleInfo niceGuesser = new RoleInfo("正义的赌怪", Guesser.color, CustomOptionHolder.guesserSpawnRate, RoleType.NiceGuesser);
        public static RoleInfo evilGuesser = new RoleInfo("邪恶的赌怪", Palette.ImpostorRed, CustomOptionHolder.guesserSpawnRate, RoleType.EvilGuesser);
        public static RoleInfo bait = new RoleInfo("诱饵", Bait.color, CustomOptionHolder.baitSpawnRate, RoleType.Bait);
        public static RoleInfo madmate = new RoleInfo("疯子", Madmate.color, CustomOptionHolder.madmateSpawnRate, RoleType.Madmate);
        public static RoleInfo impostor = new RoleInfo("内鬼", Palette.ImpostorRed,null, RoleType.Impostor);
        public static RoleInfo lawyer = new RoleInfo("律师", Lawyer.color, CustomOptionHolder.lawyerSpawnRate, RoleType.Lawyer);
        public static RoleInfo pursuer = new RoleInfo("起诉人", Pursuer.color, CustomOptionHolder.lawyerSpawnRate, RoleType.Pursuer);
        public static RoleInfo crewmate = new RoleInfo("船员", Color.white, null, RoleType.Crewmate);
        public static RoleInfo lovers = new RoleInfo("恋人", Lovers.color, CustomOptionHolder.loversSpawnRate, RoleType.Lovers);
        public static RoleInfo gm = new RoleInfo("游戏管理者", GM.color, CustomOptionHolder.gmEnabled, RoleType.GM);
        public static RoleInfo opportunist = new RoleInfo("机会主义者", Opportunist.color, CustomOptionHolder.opportunistSpawnRate, RoleType.Opportunist);
        public static RoleInfo witch = new RoleInfo("女巫", Witch.color, CustomOptionHolder.witchSpawnRate, RoleType.Witch);
        public static RoleInfo vulture = new RoleInfo("秃鹫", Vulture.color, CustomOptionHolder.vultureSpawnRate, RoleType.Vulture);
        public static RoleInfo medium = new RoleInfo("通灵师", Medium.color, CustomOptionHolder.mediumSpawnRate, RoleType.Medium);
        public static RoleInfo ninja = new RoleInfo("忍者", Ninja.color, CustomOptionHolder.ninjaSpawnRate, RoleType.Ninja);
        public static RoleInfo plagueDoctor = new RoleInfo("瘟疫医生", PlagueDoctor.color, CustomOptionHolder.plagueDoctorSpawnRate, RoleType.PlagueDoctor);
        public static RoleInfo nekoKabocha = new RoleInfo("猎人", NekoKabocha.color, CustomOptionHolder.nekoKabochaSpawnRate, RoleType.NekoKabocha);
        public static RoleInfo serialKiller = new RoleInfo("连环杀手", SerialKiller.color, CustomOptionHolder.serialKillerSpawnRate, RoleType.SerialKiller);

        public static List<RoleInfo> allRoleInfos = new List<RoleInfo>() {
                impostor,
                godfather,
                mafioso,
                janitor,
                morphling,
                camouflager,
                vampire,
                eraser,
                trickster,
                cleaner,
                warlock,
                bountyHunter,
                witch,
                ninja,
                serialKiller,
                niceMini,
                evilMini,
                niceGuesser,
                evilGuesser,
                lovers,
                jester,
                arsonist,
                jackal,
                sidekick,
            	vulture,
                pursuer,
                lawyer,
                crewmate,
                niceShifter,
                corruptedShifter,
                mayor,
                engineer,
                sheriff,
                lighter,
                detective,
                timeMaster,
                medic,
                niceSwapper,
                evilSwapper,
                seer,
                hacker,
                tracker,
                snitch,
                spy,
                securityGuard,
                bait,
                madmate,
                gm,
                opportunist,
	            medium,
                plagueDoctor,
                nekoKabocha,
            };

        public static string tl(string key)
        {
            return ModTranslation.getString(key);
        }

        public static List<RoleInfo> getRoleInfoForPlayer(PlayerControl p, RoleType[] excludeRoles = null) {
            List<RoleInfo> infos = new List<RoleInfo>();
            if (p == null) return infos;

            // Special roles
            if (p.isRole(RoleType.Jester)) infos.Add(jester);
            if (p.isRole(RoleType.Mayor)) infos.Add(mayor);
            if (p.isRole(RoleType.Engineer)) infos.Add(engineer);
            if (p.isRole(RoleType.Sheriff)) infos.Add(sheriff);
            if (p.isRole(RoleType.Lighter)) infos.Add(lighter);
            if (p.isRole(RoleType.Godfather)) infos.Add(godfather);
            if (p.isRole(RoleType.Mafioso)) infos.Add(mafioso);
            if (p.isRole(RoleType.Janitor)) infos.Add(janitor);
            if (p.isRole(RoleType.Morphling)) infos.Add(morphling);
            if (p.isRole(RoleType.Camouflager)) infos.Add(camouflager);
            if (p.isRole(RoleType.Vampire)) infos.Add(vampire);
            if (p.isRole(RoleType.Eraser)) infos.Add(eraser);
            if (p.isRole(RoleType.Trickster)) infos.Add(trickster);
            if (p.isRole(RoleType.Cleaner)) infos.Add(cleaner);
            if (p.isRole(RoleType.Warlock)) infos.Add(warlock);
            if (p.isRole(RoleType.Witch)) infos.Add(witch);
            if (p.isRole(RoleType.Detective)) infos.Add(detective);
            if (p.isRole(RoleType.TimeMaster)) infos.Add(timeMaster);
            if (p.isRole(RoleType.Medic)) infos.Add(medic);
            if (p.isRole(RoleType.Shifter)) infos.Add(Shifter.isNeutral ? corruptedShifter : niceShifter);
            if (p.isRole(RoleType.Swapper)) infos.Add(p.Data.Role.IsImpostor ? evilSwapper : niceSwapper);
            if (p.isRole(RoleType.Seer)) infos.Add(seer);
            if (p.isRole(RoleType.Hacker)) infos.Add(hacker);
            if (p.isRole(RoleType.Mini)) infos.Add(p.Data.Role.IsImpostor ? evilMini : niceMini);
            if (p.isRole(RoleType.Tracker)) infos.Add(tracker);
            if (p.isRole(RoleType.Snitch)) infos.Add(snitch);
            if (p.isRole(RoleType.Jackal) || (Jackal.formerJackals != null && Jackal.formerJackals.Any(x => x.PlayerId == p.PlayerId))) infos.Add(jackal);
            if (p.isRole(RoleType.Sidekick)) infos.Add(sidekick);
            if (p.isRole(RoleType.Spy)) infos.Add(spy);
            if (p.isRole(RoleType.SecurityGuard)) infos.Add(securityGuard);
            if (p.isRole(RoleType.Arsonist)) infos.Add(arsonist);
            if (p.isRole(RoleType.NiceGuesser)) infos.Add(niceGuesser);
            if (p.isRole(RoleType.EvilGuesser)) infos.Add(evilGuesser);
            if (p.isRole(RoleType.BountyHunter)) infos.Add(bountyHunter);
            if (p.isRole(RoleType.Bait)) infos.Add(bait);
            if (p.isRole(RoleType.Madmate)) infos.Add(madmate);
            if (p.isRole(RoleType.GM)) infos.Add(gm);
            if (p.isRole(RoleType.Opportunist)) infos.Add(opportunist);
            if (p.isRole(RoleType.Vulture)) infos.Add(vulture);
            if (p.isRole(RoleType.Medium)) infos.Add(medium);
            if (p.isRole(RoleType.Lawyer)) infos.Add(lawyer);
            if (p.isRole(RoleType.Pursuer)) infos.Add(pursuer);
            if (p.isRole(RoleType.Ninja)) infos.Add(ninja);
            if (p.isRole(RoleType.PlagueDoctor)) infos.Add(plagueDoctor);
            if (p.isRole(RoleType.NekoKabocha)) infos.Add(nekoKabocha);
            if (p.isRole(RoleType.SerialKiller)) infos.Add(serialKiller);


            // Default roles
            if (infos.Count == 0 && p.Data.Role.IsImpostor) infos.Add(impostor); // Just Impostor
            if (infos.Count == 0 && !p.Data.Role.IsImpostor) infos.Add(crewmate); // Just Crewmate

            // Modifier
            if (p.isLovers()) infos.Add(lovers);

            if (excludeRoles != null)
                infos.RemoveAll(x => excludeRoles.Contains(x.roleId));

            return infos;
        }

        public static String GetRolesString(PlayerControl p, bool useColors, RoleType[] excludeRoles = null) {
            string roleName = "";
            if (p?.Data?.Disconnected != false) return roleName;

            roleName = String.Join(" ", getRoleInfoForPlayer(p, excludeRoles).Select(x => useColors ? Helpers.cs(x.color, x.name) : x.name).ToArray());
            if (Lawyer.target != null && p?.PlayerId == Lawyer.target.PlayerId && PlayerControl.LocalPlayer != Lawyer.target) roleName += (useColors ? Helpers.cs(Pursuer.color, " §") : " §");
            return roleName;
        }
    }
}
