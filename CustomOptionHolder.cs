using System.Collections.Generic;
using UnityEngine;
using BepInEx.Configuration;
using System;
using System.Linq;
using HarmonyLib;
using Hazel;
using System.Reflection;
using System.Text;
using static TheOtherRoles.TheOtherRoles;
using static TheOtherRoles.TheOtherRolesGM;

namespace TheOtherRoles {

    public class CustomOptionHolder {
        public static string[] rates = new string[]{
        
        
        
        0%
            , "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"};
        public static string[] presets = new string[]{"预设1", "预设2", "预设3", "预设4", "预设5" };

        public static CustomOption presetSelection;
        public static CustomOption activateRoles;
        public static CustomOption crewmateRolesCountMin;
        public static CustomOption crewmateRolesCountMax;
        public static CustomOption neutralRolesCountMin;
        public static CustomOption neutralRolesCountMax;
        public static CustomOption impostorRolesCountMin;
        public static CustomOption impostorRolesCountMax;

        public static CustomRoleOption mafiaSpawnRate;
        public static CustomOption janitorCooldown;

        public static CustomRoleOption morphlingSpawnRate;
        public static CustomOption morphlingCooldown;
        public static CustomOption morphlingDuration;

        public static CustomRoleOption camouflagerSpawnRate;
        public static CustomOption camouflagerCooldown;
        public static CustomOption camouflagerDuration;
        public static CustomOption camouflagerRandomColors;

        public static CustomRoleOption vampireSpawnRate;
        public static CustomOption vampireKillDelay;
        public static CustomOption vampireCooldown;
        public static CustomOption vampireCanKillNearGarlics;

        public static CustomRoleOption eraserSpawnRate;
        public static CustomOption eraserCooldown;
        public static CustomOption eraserCooldownIncrease;
        public static CustomOption eraserCanEraseAnyone;

        public static CustomRoleOption miniSpawnRate;
        public static CustomOption miniGrowingUpDuration;
        public static CustomOption miniIsImpRate;

        public static CustomOption loversSpawnRate;
        public static CustomOption loversNumCouples;
        public static CustomOption loversImpLoverRate;
        public static CustomOption loversBothDie;
        public static CustomOption loversCanHaveAnotherRole;
        public static CustomOption loversSeparateTeam;
        public static CustomOption loversTasksCount;
        public static CustomOption loversEnableChat;

        public static CustomRoleOption guesserSpawnRate;
        public static CustomOption guesserIsImpGuesserRate;
        public static CustomOption guesserNumberOfShots;
        public static CustomOption guesserOnlyAvailableRoles;
        public static CustomOption guesserHasMultipleShotsPerMeeting;
        public static CustomOption guesserShowInfoInGhostChat;
        public static CustomOption guesserKillsThroughShield;
        public static CustomOption guesserEvilCanKillSpy;
        public static CustomOption guesserSpawnBothRate;
        public static CustomOption guesserCantGuessSnitchIfTaksDone;

        public static CustomRoleOption jesterSpawnRate;
        public static CustomOption jesterCanCallEmergency;
        public static CustomOption jesterCanSabotage;
        public static CustomOption jesterHasImpostorVision;

        public static CustomRoleOption arsonistSpawnRate;
        public static CustomOption arsonistCooldown;
        public static CustomOption arsonistDuration;
        public static CustomOption arsonistCanBeLovers;

        public static CustomRoleOption jackalSpawnRate;
        public static CustomOption jackalKillCooldown;
        public static CustomOption jackalCreateSidekickCooldown;
        public static CustomOption jackalCanUseVents;
        public static CustomOption jackalCanCreateSidekick;
        public static CustomOption sidekickPromotesToJackal;
        public static CustomOption sidekickCanKill;
        public static CustomOption sidekickCanUseVents;
        public static CustomOption jackalPromotedFromSidekickCanCreateSidekick;
        public static CustomOption jackalCanCreateSidekickFromImpostor;
        public static CustomOption jackalAndSidekickHaveImpostorVision;
        public static CustomOption jackalCanSeeEngineerVent;

        public static CustomRoleOption bountyHunterSpawnRate;
        public static CustomOption bountyHunterBountyDuration;
        public static CustomOption bountyHunterReducedCooldown;
        public static CustomOption bountyHunterPunishmentTime;
        public static CustomOption bountyHunterShowArrow;
        public static CustomOption bountyHunterArrowUpdateIntervall;

        public static CustomRoleOption witchSpawnRate;
        public static CustomOption witchCooldown;
        public static CustomOption witchAdditionalCooldown;
        public static CustomOption witchCanSpellAnyone;
        public static CustomOption witchSpellCastingDuration;
        public static CustomOption witchTriggerBothCooldowns;
        public static CustomOption witchVoteSavesTargets;

        public static CustomRoleOption shifterSpawnRate;
        public static CustomOption shifterIsNeutralRate;
        public static CustomOption shifterShiftsModifiers;
        public static CustomOption shifterPastShifters;

        public static CustomRoleOption mayorSpawnRate;
        public static CustomOption mayorNumVotes;

        public static CustomRoleOption engineerSpawnRate;
        public static CustomOption engineerNumberOfFixes;
        public static CustomOption engineerHighlightForImpostors;
        public static CustomOption engineerHighlightForTeamJackal;

        public static CustomRoleOption sheriffSpawnRate;
        public static CustomOption sheriffCooldown;
        public static CustomOption sheriffNumShots;
        public static CustomOption sheriffCanKillNeutrals;
        public static CustomOption sheriffMisfireKillsTarget;

        public static CustomRoleOption lighterSpawnRate;
        public static CustomOption lighterModeLightsOnVision;
        public static CustomOption lighterModeLightsOffVision;
        public static CustomOption lighterCooldown;
        public static CustomOption lighterDuration;
        public static CustomOption lighterCanSeeNinja;

        public static CustomRoleOption detectiveSpawnRate;
        public static CustomOption detectiveAnonymousFootprints;
        public static CustomOption detectiveFootprintIntervall;
        public static CustomOption detectiveFootprintDuration;
        public static CustomOption detectiveReportNameDuration;
        public static CustomOption detectiveReportColorDuration;

        public static CustomRoleOption timeMasterSpawnRate;
        public static CustomOption timeMasterCooldown;
        public static CustomOption timeMasterRewindTime;
        public static CustomOption timeMasterShieldDuration;

        public static CustomRoleOption medicSpawnRate;
        public static CustomOption medicShowShielded;
        public static CustomOption medicShowAttemptToShielded;
        public static CustomOption medicSetShieldAfterMeeting;
        public static CustomOption medicShowAttemptToMedic;

        public static CustomRoleOption swapperSpawnRate;
        public static CustomOption swapperIsImpRate;
        public static CustomOption swapperCanCallEmergency;
        public static CustomOption swapperCanOnlySwapOthers;
        public static CustomOption swapperNumSwaps;

        public static CustomRoleOption seerSpawnRate;
        public static CustomOption seerMode;
        public static CustomOption seerSoulDuration;
        public static CustomOption seerLimitSoulDuration;

        public static CustomRoleOption hackerSpawnRate;
        public static CustomOption hackerCooldown;
        public static CustomOption hackerHackeringDuration;
        public static CustomOption hackerOnlyColorType;
        public static CustomOption hackerToolsNumber;
        public static CustomOption hackerRechargeTasksNumber;
        public static CustomOption hackerNoMove;

        public static CustomRoleOption trackerSpawnRate;
        public static CustomOption trackerUpdateIntervall;
        public static CustomOption trackerResetTargetAfterMeeting;
        public static CustomOption trackerCanTrackCorpses;
        public static CustomOption trackerCorpsesTrackingCooldown;
        public static CustomOption trackerCorpsesTrackingDuration;

        public static CustomRoleOption snitchSpawnRate;
        public static CustomOption snitchLeftTasksForReveal;
        public static CustomOption snitchIncludeTeamJackal;
        public static CustomOption snitchTeamJackalUseDifferentArrowColor;

        public static CustomRoleOption spySpawnRate;
        public static CustomOption spyCanDieToSheriff;
        public static CustomOption spyImpostorsCanKillAnyone;
        public static CustomOption spyCanEnterVents;
        public static CustomOption spyHasImpostorVision;

        public static CustomRoleOption tricksterSpawnRate;
        public static CustomOption tricksterPlaceBoxCooldown;
        public static CustomOption tricksterLightsOutCooldown;
        public static CustomOption tricksterLightsOutDuration;

        public static CustomRoleOption cleanerSpawnRate;
        public static CustomOption cleanerCooldown;
        
        public static CustomRoleOption warlockSpawnRate;
        public static CustomOption warlockCooldown;
        public static CustomOption warlockRootTime;

        public static CustomRoleOption securityGuardSpawnRate;
        public static CustomOption securityGuardCooldown;
        public static CustomOption securityGuardTotalScrews;
        public static CustomOption securityGuardCamPrice;
        public static CustomOption securityGuardVentPrice;
        public static CustomOption securityGuardCamDuration;
        public static CustomOption securityGuardCamMaxCharges;
        public static CustomOption securityGuardCamRechargeTasksNumber;
        public static CustomOption securityGuardNoMove;

        public static CustomRoleOption baitSpawnRate;
        public static CustomOption baitHighlightAllVents;
        public static CustomOption baitReportDelay;
        public static CustomOption baitShowKillFlash;
		
		public static CustomRoleOption vultureSpawnRate;
        public static CustomOption vultureCooldown;
        public static CustomOption vultureNumberToWin;
        public static CustomOption vultureCanUseVents;
        public static CustomOption vultureShowArrows;

        public static CustomRoleOption mediumSpawnRate;
        public static CustomOption mediumCooldown;
        public static CustomOption mediumDuration;
        public static CustomOption mediumOneTimeUse;

        public static CustomRoleOption lawyerSpawnRate;
        public static CustomOption lawyerTargetKnows;
        public static CustomOption lawyerWinsAfterMeetings;
        public static CustomOption lawyerNeededMeetings;
        public static CustomOption lawyerVision;
        public static CustomOption lawyerKnowsRole;
        public static CustomOption pursuerCooldown;
        public static CustomOption pursuerBlanksNumber;

        public static CustomOption specialOptions;
        public static CustomOption maxNumberOfMeetings;
        public static CustomOption blockSkippingInEmergencyMeetings;
        public static CustomOption noVoteIsSelfVote;
        public static CustomOption hidePlayerNames;

		public static CustomOption allowParallelMedBayScans;

        public static CustomOption dynamicMap;
        public static CustomOption dynamicMapEnableSkeld;
        public static CustomOption dynamicMapEnableMira;
        public static CustomOption dynamicMapEnablePolus;
        public static CustomOption dynamicMapEnableDleks;
        public static CustomOption dynamicMapEnableAirShip;

        // GM Edition options
        public static CustomRoleOption madmateSpawnRate;
        public static CustomOption madmateCanDieToSheriff;
        public static CustomOption madmateCanEnterVents;
        public static CustomOption madmateHasImpostorVision;
        public static CustomOption madmateCanSabotage;
        public static CustomOption madmateCanFixComm;

        public static CustomRoleOption opportunistSpawnRate;

        public static CustomRoleOption ninjaSpawnRate;
        public static CustomOption ninjaStealthCooldown;
        public static CustomOption ninjaStealthDuration;
        public static CustomOption ninjaKillPenalty;
        public static CustomOption ninjaSpeedBonus;
        public static CustomOption ninjaFadeTime;
        public static CustomOption ninjaCanVent;
        public static CustomOption ninjaCanBeTargeted;

        public static CustomOption gmEnabled;
        public static CustomOption gmIsHost;
        public static CustomOption gmHasTasks;
        public static CustomOption gmDiesAtStart;
        public static CustomOption gmCanWarp;
        public static CustomOption gmCanKill;

        public static CustomRoleOption plagueDoctorSpawnRate;
        public static CustomOption plagueDoctorInfectCooldown;
        public static CustomOption plagueDoctorNumInfections;
        public static CustomOption plagueDoctorDistance;
        public static CustomOption plagueDoctorDuration;
        public static CustomOption plagueDoctorImmunityTime;
        public static CustomOption plagueDoctorInfectKiller;
        public static CustomOption plagueDoctorResetMeeting;
        public static CustomOption plagueDoctorWinDead;

        public static CustomRoleOption nekoKabochaSpawnRate;
        public static CustomOption nekoKabochaRevengeCrew;
        public static CustomOption nekoKabochaRevengeNeutral;
        public static CustomOption nekoKabochaRevengeImpostor;
        public static CustomOption nekoKabochaRevengeExile;

        public static CustomOption hideSettings;
        public static CustomOption restrictDevices;
        public static CustomOption restrictAdmin;
        public static CustomOption restrictCameras;
        public static CustomOption restrictVents;

        public static CustomOption hideOutOfSightNametags;

        public static CustomOption uselessOptions;
        public static CustomOption playerColorRandom;
        public static CustomOption playerNameDupes;
        public static CustomOption disableVents;

        public static CustomRoleOption serialKillerSpawnRate;
        public static CustomOption serialKillerKillCooldown;
        public static CustomOption serialKillerSuicideTimer;
        public static CustomOption serialKillerResetTimer;

        internal static Dictionary<byte, byte[]> blockedRolePairings = new Dictionary<byte, byte[]>();

        public static string cs(Color c, string s) {
            return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), s);
        }
 
        private static byte ToByte(float f) {
            f = Mathf.Clamp01(f);
            return (byte)(f * 255);
        }

        public static void Load() {

            // Role Options
            activateRoles = CustomOption.Create(7, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "禁用原版职业并启用mod职业"), true, null, true);

            presetSelection = CustomOption.Create(0, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "预设"), presets, null, true);

            // Using new id's for the options to not break compatibilty with older versions
            crewmateRolesCountMin = CustomOption.Create(300, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最小船员职业个数"), 0f, 0f, 15f, 1f, null, true);
            crewmateRolesCountMax = CustomOption.Create(301, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最小船员职业个数"), 0f, 0f, 15f, 1f);
            neutralRolesCountMin = CustomOption.Create(302, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最小中立职业个数"), 0f, 0f, 15f, 1f);
            neutralRolesCountMax = CustomOption.Create(303, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最小中立职业个数"), 0f, 0f, 15f, 1f);
            impostorRolesCountMin = CustomOption.Create(304, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最小内鬼职业个数"), 0f, 0f, 15f, 1f);
            impostorRolesCountMax = CustomOption.Create(305, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最小内鬼职业个数"), 0f, 0f, 15f, 1f);


            gmEnabled = CustomOption.Create(400, cs(GM.color, "游戏管理者"), false, null, true);
            gmIsHost = CustomOption.Create(401, "游戏管理者一定是房主", true, gmEnabled);
            //gmHasTasks = CustomOption.Create(402, "gmHasTasks", false, gmEnabled);
            gmCanWarp = CustomOption.Create(405, "游戏管理者可瞬移到玩家", true, gmEnabled);
            gmCanKill = CustomOption.Create(406, "游戏管理者可以杀人", false, gmEnabled);
            gmDiesAtStart = CustomOption.Create(404, "游戏管理者在游戏开始时死亡", true, gmEnabled);


            mafiaSpawnRate = new CustomRoleOption(10, "黑手党", Janitor.color, 1);
            janitorCooldown = CustomOption.Create(11, "清洁工冷却", 30f, 2.5f, 60f, 2.5f, mafiaSpawnRate, format : "unitSeconds");

            morphlingSpawnRate = new CustomRoleOption(20, "化形者", Morphling.color, 1);
            morphlingCooldown = CustomOption.Create(21, "化形者冷却", 30f, 2.5f, 60f, 2.5f, morphlingSpawnRate, format: "unitSeconds");
            morphlingDuration = CustomOption.Create(22, "化形持续时间", 10f, 1f, 20f, 0.5f, morphlingSpawnRate, format: "unitSeconds");

            camouflagerSpawnRate = new CustomRoleOption(30, "隐蔽者", Camouflager.color, 1);
            camouflagerCooldown = CustomOption.Create(31, "隐蔽者冷却", 30f, 2.5f, 60f, 2.5f, camouflagerSpawnRate, format: "unitSeconds");
            camouflagerDuration = CustomOption.Create(32, "隐蔽者持续时间", 10f, 1f, 20f, 0.5f, camouflagerSpawnRate, format: "unitSeconds");
            camouflagerRandomColors = CustomOption.Create(33, "隐蔽者随机颜色", false, camouflagerSpawnRate);

            vampireSpawnRate = new CustomRoleOption(40, "吸血鬼", Vampire.color, 1);
            vampireKillDelay = CustomOption.Create(41, "吸血鬼杀人延迟", 10f, 1f, 20f, 1f, vampireSpawnRate, format: "unitSeconds");
            vampireCooldown = CustomOption.Create(42, "吸血鬼冷却", 30f, 2.5f, 60f, 2.5f, vampireSpawnRate, format: "unitSeconds");
            vampireCanKillNearGarlics = CustomOption.Create(43, "吸血鬼可在大蒜内杀人", true, vampireSpawnRate);

            eraserSpawnRate = new CustomRoleOption(230, "抹除者", Eraser.color, 1);
            eraserCooldown = CustomOption.Create(231, "抹除者冷却", 30f, 5f, 120f, 5f, eraserSpawnRate, format: "unitSeconds");
            eraserCooldownIncrease = CustomOption.Create(233, "抹除者冷却加长", 10f, 0f, 120f, 2.5f, eraserSpawnRate, format: "unitSeconds");
            eraserCanEraseAnyone = CustomOption.Create(232, "抹除者可抹除任何人", false, eraserSpawnRate);

            tricksterSpawnRate = new CustomRoleOption(250, "骗术师", Trickster.color, 1);
            tricksterPlaceBoxCooldown = CustomOption.Create(251, "骗术师放置惊吓盒冷却", 10f, 2.5f, 30f, 2.5f, tricksterSpawnRate, format: "unitSeconds");
            tricksterLightsOutCooldown = CustomOption.Create(252, "骗术师熄灯冷却", 30f, 5f, 60f, 5f, tricksterSpawnRate, format: "unitSeconds");
            tricksterLightsOutDuration = CustomOption.Create(253, "骗术师熄灯持续时长", 15f, 5f, 60f, 2.5f, tricksterSpawnRate, format: "unitSeconds");

            cleanerSpawnRate = new CustomRoleOption(260, "清理者", Cleaner.color, 1);
            cleanerCooldown = CustomOption.Create(261, "清理者冷却", 30f, 2.5f, 60f, 2.5f, cleanerSpawnRate, format: "unitSeconds");

            warlockSpawnRate = new CustomRoleOption(270, "术士", Warlock.color, 1);
            warlockCooldown = CustomOption.Create(271, "术士冷却", 30f, 2.5f, 60f, 2.5f, warlockSpawnRate, format: "unitSeconds");
            warlockRootTime = CustomOption.Create(272, "术士咒杀人后静置时间", 5f, 0f, 15f, 1f, warlockSpawnRate, format: "unitSeconds");

            bountyHunterSpawnRate = new CustomRoleOption(320, "赏金猎人", BountyHunter.color, 1);
            bountyHunterBountyDuration = CustomOption.Create(321, "赏金猎人目标持续时间", 60f, 10f, 180f, 10f, bountyHunterSpawnRate, format: "unitSeconds");
            bountyHunterReducedCooldown = CustomOption.Create(322, "赏金猎人杀死目标后冷却时间（奖励）", 2.5f, 2.5f, 30f, 2.5f, bountyHunterSpawnRate, format: "unitSeconds");
            bountyHunterPunishmentTime = CustomOption.Create(323, "赏金猎人杀死非目标后冷却时间（惩罚）", 20f, 0f, 60f, 2.5f, bountyHunterSpawnRate, format: "unitSeconds");
            bountyHunterShowArrow = CustomOption.Create(324, "赏金猎人可见目标位置箭头", true, bountyHunterSpawnRate);
            bountyHunterArrowUpdateIntervall = CustomOption.Create(325, "赏金猎人目标位置箭头更新位置间隔时间", 15f, 2.5f, 60f, 2.5f, bountyHunterShowArrow, format: "unitSeconds");

            witchSpawnRate = new CustomRoleOption(390, "女巫", Witch.color, 1);
            witchCooldown = CustomOption.Create(391, "女巫下咒冷却时间", 30f, 2.5f, 120f, 2.5f, witchSpawnRate, format: "unitSeconds");
            witchAdditionalCooldown = CustomOption.Create(392, "女巫下咒后递增冷却时间", 10f, 0f, 60f, 5f, witchSpawnRate, format: "unitSeconds");
            witchCanSpellAnyone = CustomOption.Create(393, "女巫可对任何人下咒", false, witchSpawnRate);
            witchSpellCastingDuration = CustomOption.Create(394, "女巫下咒持续时间", 1f, 0f, 10f, 1f, witchSpawnRate, format: "unitSeconds");
            witchTriggerBothCooldowns = CustomOption.Create(395, "女巫下咒和杀人共享冷却时间", true, witchSpawnRate);
            witchVoteSavesTargets = CustomOption.Create(396, "女巫死后被标记者存活", true, witchSpawnRate);


            ninjaSpawnRate = new CustomRoleOption(1000, "忍者", Ninja.color, 3);
            ninjaStealthCooldown = CustomOption.Create(1002, "忍者隐身冷却时间", 30f, 2.5f, 60f, 2.5f, ninjaSpawnRate, format: "unitSeconds");
            ninjaStealthDuration = CustomOption.Create(1003, "忍者隐身持续时长", 15f, 2.5f, 60f, 2.5f, ninjaSpawnRate, format: "unitSeconds");
            ninjaFadeTime = CustomOption.Create(1004, "忍者从隐形到显形渐变时间", 0.5f, 0.0f, 2.5f, 0.5f, ninjaSpawnRate, format: "unitSeconds");
            ninjaKillPenalty = CustomOption.Create(1005, "忍者杀人后惩罚冷却", 10f, 0f, 60f, 2.5f, ninjaSpawnRate, format: "unitSeconds");
            ninjaSpeedBonus = CustomOption.Create(1006, "忍者速度提升", 125f, 50f, 200f, 5f, ninjaSpawnRate, format: "unitPercent");
            ninjaCanBeTargeted = CustomOption.Create(1007, "忍者可被女巫标记", true, ninjaSpawnRate);
            ninjaCanVent = CustomOption.Create(1008, "忍者可跳管道", false, ninjaSpawnRate);

            serialKillerSpawnRate = new CustomRoleOption(1010, "连环杀手", SerialKiller.color, 3);
            serialKillerKillCooldown = CustomOption.Create(1012, "连环杀手杀人时间", 15f, 2.5f, 60f, 2.5f, serialKillerSpawnRate, format: "unitSeconds");
            serialKillerSuicideTimer = CustomOption.Create(1013, "连环杀手嗜血时长", 40f, 2.5f, 60f, 2.5f, serialKillerSpawnRate, format: "unitSeconds");
            serialKillerResetTimer = CustomOption.Create(1014, "会议后重置嗜血时长", true, serialKillerSpawnRate);

            nekoKabochaSpawnRate = new CustomRoleOption(1020, "猎人", NekoKabocha.color, 3);
            nekoKabochaRevengeCrew = CustomOption.Create(1021, "反杀船员杀手", true, nekoKabochaSpawnRate);
            nekoKabochaRevengeNeutral = CustomOption.Create(1022, "反杀中立杀手", true, nekoKabochaSpawnRate);
            nekoKabochaRevengeImpostor = CustomOption.Create(1023, "反杀内鬼杀手", true, nekoKabochaSpawnRate);
            nekoKabochaRevengeExile = CustomOption.Create(1024, "被驱逐时反杀", false, nekoKabochaSpawnRate);


            madmateSpawnRate = new CustomRoleOption(360, "疯子", Madmate.color);
            madmateCanDieToSheriff = CustomOption.Create(361, "警长可杀死疯子", false, madmateSpawnRate);
            madmateCanEnterVents = CustomOption.Create(362, "疯子可跳管道", false, madmateSpawnRate);
            madmateHasImpostorVision = CustomOption.Create(363, "疯子有内鬼视野", false, madmateSpawnRate);
            madmateCanSabotage = CustomOption.Create(364, "疯子可破坏", false, madmateSpawnRate);
            madmateCanFixComm = CustomOption.Create(365, "疯子可修复通讯", true, madmateSpawnRate);

            miniSpawnRate = new CustomRoleOption(180, "迷你船员", Mini.color, 1);
            miniIsImpRate = CustomOption.Create(182, "坏迷你船员生成概率", rates, miniSpawnRate);
            miniGrowingUpDuration = CustomOption.Create(181, "迷你船员长大时长", 400f, 100f, 1500f, 100f, miniSpawnRate, format: "unitSeconds");

            loversSpawnRate = new CustomRoleOption(50, "恋人", Lovers.color, 1);
            loversImpLoverRate = CustomOption.Create(51, "内鬼恋人生成概率", rates, loversSpawnRate);
            loversNumCouples = CustomOption.Create(57, "恋人对数", 1f, 1f, 7f, 1f, loversSpawnRate, format: "unitCouples");
            loversBothDie = CustomOption.Create(52, "恋人共死", true, loversSpawnRate);
            loversCanHaveAnotherRole = CustomOption.Create(53, "恋人可拥有其他职业", true, loversSpawnRate);
            loversSeparateTeam = CustomOption.Create(56, "恋人为分离队伍", true, loversSpawnRate);
            loversTasksCount = CustomOption.Create(55, "恋人活着的时候计算任务", false, loversSpawnRate);
			loversEnableChat = CustomOption.Create(54, "恋人可私聊", true, loversSpawnRate);

            guesserSpawnRate = new CustomRoleOption(310, "赌怪", Guesser.color, 1);
            guesserIsImpGuesserRate = CustomOption.Create(311, "坏赌怪生成概率", rates, guesserSpawnRate);
            guesserSpawnBothRate = CustomOption.Create(317, "双赌怪概率", rates, guesserSpawnRate);
            guesserNumberOfShots = CustomOption.Create(312, "赌怪猜测次数", 2f, 1f, 15f, 1f, guesserSpawnRate, format: "unitShots");
            guesserOnlyAvailableRoles = CustomOption.Create(313, "赌怪面板只显示开启职业", true, guesserSpawnRate);
            guesserHasMultipleShotsPerMeeting = CustomOption.Create(314, "赌怪可在会议多次猜测", false, guesserSpawnRate);
            guesserShowInfoInGhostChat = CustomOption.Create(315, "鬼魂显示赌怪猜测信息", true, guesserSpawnRate);
            guesserKillsThroughShield = CustomOption.Create(316, "赌怪无视医生护盾", true, guesserSpawnRate);
            guesserEvilCanKillSpy = CustomOption.Create(318, "坏赌怪可猜测卧底", true, guesserSpawnRate);
			guesserCantGuessSnitchIfTaksDone = CustomOption.Create(319, "坏赌怪可猜测完成任务的告密者", true, guesserSpawnRate);

            swapperSpawnRate = new CustomRoleOption(150, "换票师", Swapper.color, 1);
            swapperIsImpRate = CustomOption.Create(153, "邪恶换票师生成概率", rates, swapperSpawnRate);
            swapperNumSwaps = CustomOption.Create(154, "换票师换票次数", 2f, 1f, 15f, 1f, swapperSpawnRate, format: "unitTimes");
            swapperCanCallEmergency = CustomOption.Create(151, "换票师可召开紧急会议", false, swapperSpawnRate);
            swapperCanOnlySwapOthers = CustomOption.Create(152, "换票师仅可以换票他人", false, swapperSpawnRate);

            jesterSpawnRate = new CustomRoleOption(60, "小丑", Jester.color, 1);
            jesterCanCallEmergency = CustomOption.Create(61, "小丑可召开紧急会议", true, jesterSpawnRate);
			jesterCanSabotage = CustomOption.Create(62, "小丑可以破坏", true, jesterSpawnRate);
            jesterHasImpostorVision = CustomOption.Create(63, "小丑有内鬼视野", false, jesterSpawnRate);

            arsonistSpawnRate = new CustomRoleOption(290, "纵火犯", Arsonist.color, 1);
            arsonistCooldown = CustomOption.Create(291, "纵火犯浇油冷却", 12.5f, 2.5f, 60f, 2.5f, arsonistSpawnRate, format: "unitSeconds");
            arsonistDuration = CustomOption.Create(292, "纵火犯浇油时长", 3f, 0f, 10f, 1f, arsonistSpawnRate, format: "unitSeconds");
            arsonistCanBeLovers = CustomOption.Create(293, "纵火犯可作为恋人", false, arsonistSpawnRate);

            opportunistSpawnRate = new CustomRoleOption(380, "机会主义者", Opportunist.color);

            jackalSpawnRate = new CustomRoleOption(220, "豺狼", Jackal.color, 1);
            jackalKillCooldown = CustomOption.Create(221, "豺狼杀人冷却时长", 30f, 2.5f, 60f, 2.5f, jackalSpawnRate, format: "unitSeconds");
            jackalCanUseVents = CustomOption.Create(223, "豺狼可跳风管", true, jackalSpawnRate);
            jackalAndSidekickHaveImpostorVision = CustomOption.Create(430, "豺狼和跟班拥有内鬼视野", false, jackalSpawnRate);
            jackalCanCreateSidekick = CustomOption.Create(224, "豺狼可招募跟班", false, jackalSpawnRate);
            jackalCreateSidekickCooldown = CustomOption.Create(222, "豺狼招募跟班冷却", 30f, 2.5f, 60f, 2.5f, jackalCanCreateSidekick, format: "unitSeconds");
            sidekickPromotesToJackal = CustomOption.Create(225, "跟班晋升为豺狼", false, jackalCanCreateSidekick);
            sidekickCanKill = CustomOption.Create(226, "跟班可杀人", false, jackalCanCreateSidekick);
            sidekickCanUseVents = CustomOption.Create(227, "跟班可调管道", true, jackalCanCreateSidekick);
            jackalPromotedFromSidekickCanCreateSidekick = CustomOption.Create(228, "豺狼可传2代", true, jackalCanCreateSidekick);
            jackalCanCreateSidekickFromImpostor = CustomOption.Create(229, "豺狼可招募内鬼", true, jackalCanCreateSidekick);

            vultureSpawnRate = new CustomRoleOption(340, "秃鹫", Vulture.color, 1);
            vultureCooldown = CustomOption.Create(341, "秃鹫冷却时间", 15f, 2.5f, 60f, 2.5f, vultureSpawnRate, format: "unitSeconds");
            vultureNumberToWin = CustomOption.Create(342, "秃鹫吃几个尸体获胜", 4f, 1f, 12f, 1f, vultureSpawnRate);
            vultureCanUseVents = CustomOption.Create(343, "秃鹫可使用管道", true, vultureSpawnRate);
            vultureShowArrows = CustomOption.Create(344, "秃鹫展示尸体箭头", true, vultureSpawnRate);

            lawyerSpawnRate = new CustomRoleOption(350, "律师", Lawyer.color, 1);
            lawyerTargetKnows = CustomOption.Create(351, "律师知道客户", true, lawyerSpawnRate);
            lawyerWinsAfterMeetings = CustomOption.Create(352, "律师可以会议次数胜利", false, lawyerSpawnRate);
            lawyerNeededMeetings = CustomOption.Create(353, "律师胜利所需会议次数", 5f, 1f, 15f, 1f, lawyerWinsAfterMeetings);
            lawyerVision = CustomOption.Create(354, "律师视野", 1f, 0.25f, 3f, 0.25f, lawyerSpawnRate, format: "unitMultiplier");
            lawyerKnowsRole = CustomOption.Create(355, "律师知道客户身份", false, lawyerSpawnRate);
            pursuerCooldown = CustomOption.Create(356, "起诉人空包弹冷却", 30f, 2.5f, 60f, 2.5f, lawyerSpawnRate, format: "unitSeconds");
            pursuerBlanksNumber = CustomOption.Create(357, "起诉人空包弹次数", 5f, 0f, 20f, 1f, lawyerSpawnRate, format: "unitShots");

            shifterSpawnRate = new CustomRoleOption(70, "交换师", Shifter.color, 1);
            shifterIsNeutralRate = CustomOption.Create(72, "中立阵营交换师生成概率", rates, shifterSpawnRate);
            shifterShiftsModifiers = CustomOption.Create(71, "shifterShiftsModifiers", false, shifterSpawnRate);
            shifterPastShifters = CustomOption.Create(73, "shifterPastShifters", false, shifterSpawnRate);

            plagueDoctorSpawnRate = new CustomRoleOption(900, "瘟疫医生", PlagueDoctor.color, 1);
            plagueDoctorInfectCooldown = CustomOption.Create(901, "瘟疫医生感染冷却时间", 10f, 2.5f, 60f, 2.5f, plagueDoctorSpawnRate, format: "unitSeconds");
            plagueDoctorNumInfections = CustomOption.Create(902, "瘟疫医生可感染人数", 1f, 1f, 15, 1f, plagueDoctorSpawnRate, format: "unitPlayers");
            plagueDoctorDistance = CustomOption.Create(903, "瘟疫医生感染范围", 1.0f, 0.25f, 5.0f, 0.25f, plagueDoctorSpawnRate, format: "unitMeters");
            plagueDoctorDuration = CustomOption.Create(904, "瘟疫医生感染时长", 5f, 1f, 30f, 1f, plagueDoctorSpawnRate, format: "unitSeconds");
            plagueDoctorImmunityTime = CustomOption.Create(905, "会议后免疫时间", 10f, 1f, 30f, 1f, plagueDoctorSpawnRate, format: "unitSeconds");
            //plagueDoctorResetMeeting = CustomOption.Create(907, "plagueDoctorResetMeeting", false, plagueDoctorSpawnRate);
            plagueDoctorInfectKiller = CustomOption.Create(906, "瘟疫医生可感染杀手", true, plagueDoctorSpawnRate);
            plagueDoctorWinDead = CustomOption.Create(908, "瘟疫医生可在死后胜利", true, plagueDoctorSpawnRate);

            mayorSpawnRate = new CustomRoleOption(80, "市长", Mayor.color, 1);
            mayorNumVotes = CustomOption.Create(81, "市长票数", 2f, 2f, 10f, 1f, mayorSpawnRate, format: "unitVotes");

            engineerSpawnRate = new CustomRoleOption(90, "工程师", Engineer.color, 1);
            engineerNumberOfFixes = CustomOption.Create(91, "工程师修理次数", 1f, 0f, 3f, 1f, engineerSpawnRate);
            engineerHighlightForImpostors = CustomOption.Create(92, "内鬼可见管道蓝光", true, engineerSpawnRate);
            engineerHighlightForTeamJackal = CustomOption.Create(93, "豺狼团队可见管道蓝光", true, engineerSpawnRate);

            sheriffSpawnRate = new CustomRoleOption(100, "警长", Sheriff.color, 15);
            sheriffCooldown = CustomOption.Create(101, "警长冷却时间", 30f, 2.5f, 60f, 2.5f, sheriffSpawnRate, format: "unitSeconds");
            sheriffNumShots = CustomOption.Create(103, "警长杀人次数", 2f, 1f, 15f, 1f, sheriffSpawnRate, format: "unitShots");
            sheriffMisfireKillsTarget = CustomOption.Create(104, "警长杀错人时目标也死亡", false, sheriffSpawnRate);
            sheriffCanKillNeutrals = CustomOption.Create(102, "警长可杀死中立阵营", false, sheriffSpawnRate);

            lighterSpawnRate = new CustomRoleOption(110, "执灯人", Lighter.color, 15);
            lighterModeLightsOnVision = CustomOption.Create(111, "灯光开启,技能开启视野", 2f, 0.25f, 5f, 0.25f, lighterSpawnRate, format: "unitMultiplier");
            lighterModeLightsOffVision = CustomOption.Create(112, "灯光关闭,技能开启视野", 0.75f, 0.25f, 5f, 0.25f, lighterSpawnRate, format: "unitMultiplier");
            lighterCooldown = CustomOption.Create(113, "执灯人冷却时间", 30f, 5f, 120f, 5f, lighterSpawnRate, format: "unitSeconds");
            lighterDuration = CustomOption.Create(114, "执灯人技能时长", 5f, 2.5f, 60f, 2.5f, lighterSpawnRate, format: "unitSeconds");
            lighterCanSeeNinja = CustomOption.Create(115, "执灯人可看见忍者", true, lighterSpawnRate);

            detectiveSpawnRate = new CustomRoleOption(120, "侦探", Detective.color, 1);
            detectiveAnonymousFootprints = CustomOption.Create(121, "侦探脚印为匿名", false, detectiveSpawnRate);
            detectiveFootprintIntervall = CustomOption.Create(122, "侦探脚印间隔更新时间", 0.5f, 0.25f, 10f, 0.25f, detectiveSpawnRate, format: "unitSeconds");
            detectiveFootprintDuration = CustomOption.Create(123, "侦探脚印保留时间", 5f, 0.25f, 10f, 0.25f, detectiveSpawnRate, format: "unitSeconds");
            detectiveReportNameDuration = CustomOption.Create(124, "侦探在几秒内可看到凶手名字", 0, 0, 60, 2.5f, detectiveSpawnRate, format: "unitSeconds");
            detectiveReportColorDuration = CustomOption.Create(125, "侦探在几秒内可看到凶手颜色类型", 20, 0, 120, 2.5f, detectiveSpawnRate, format: "unitSeconds");

            timeMasterSpawnRate = new CustomRoleOption(130, "时间之主", TimeMaster.color, 1);
            timeMasterCooldown = CustomOption.Create(131, "时间之主时间之盾冷却", 30f, 2.5f, 120f, 2.5f, timeMasterSpawnRate, format: "unitSeconds");
            timeMasterRewindTime = CustomOption.Create(132, "时间之主回溯时长", 3f, 1f, 10f, 1f, timeMasterSpawnRate, format: "unitSeconds");
            timeMasterShieldDuration = CustomOption.Create(133, "时间之主时间之盾时长", 3f, 1f, 20f, 1f, timeMasterSpawnRate, format: "unitSeconds");

            medicSpawnRate = new CustomRoleOption(140, "医生", Medic.color, 1);
            medicShowShielded = CustomOption.Create(143, "可见盾", new string[] { "所有人", "医生和被上盾人", "医生" }, medicSpawnRate);
            medicShowAttemptToShielded = CustomOption.Create(144, "被上盾玩家可见谋杀企图", false, medicSpawnRate);
            medicSetShieldAfterMeeting = CustomOption.Create(145, "盾在会议后生效", false, medicSpawnRate);
            medicShowAttemptToMedic = CustomOption.Create(146, "医生可见谋杀企图", false, medicSpawnRate);

            seerSpawnRate = new CustomRoleOption(160, "灵媒", Seer.color, 1);
            seerMode = CustomOption.Create(161, "模式", new string[] { "死人闪光+灵魂", "死人闪光", "灵魂" }, seerSpawnRate);
            seerLimitSoulDuration = CustomOption.Create(163, "灵媒看见灵魂时间有限制", false, seerSpawnRate);
            seerSoulDuration = CustomOption.Create(162, "灵媒看见灵魂时间", 15f, 0f, 120f, 5f, seerLimitSoulDuration, format: "unitSeconds");

            hackerSpawnRate = new CustomRoleOption(170, "黑客", Hacker.color, 1);
            hackerCooldown = CustomOption.Create(171, "黑客黑入冷却", 30f, 5f, 60f, 5f, hackerSpawnRate, format: "unitSeconds");
            hackerHackeringDuration = CustomOption.Create(172, "黑客黑入时长", 10f, 2.5f, 60f, 2.5f, hackerSpawnRate, format: "unitSeconds");
            hackerOnlyColorType = CustomOption.Create(173, "黑客仅能看到颜色深浅", false, hackerSpawnRate);
            hackerToolsNumber = CustomOption.Create(174, "黑客最多查看移动工具次数", 5f, 1f, 30f, 1f, hackerSpawnRate);
            hackerRechargeTasksNumber = CustomOption.Create(175, "黑客完成多少任务可填满远程设备使用次数", 2f, 1f, 5f, 1f, hackerSpawnRate);
            hackerNoMove = CustomOption.Create(176, "黑客黑入时不能移动", true, hackerSpawnRate);

            trackerSpawnRate = new CustomRoleOption(200, "追踪者", Tracker.color, 1);
            trackerUpdateIntervall = CustomOption.Create(201, "追踪者目标箭头更新间隔", 5f, 2.5f, 30f, 2.5f, trackerSpawnRate, format: "unitSeconds");
            trackerResetTargetAfterMeeting = CustomOption.Create(202, "追踪者在会议后重置箭头", false, trackerSpawnRate);
            trackerCanTrackCorpses = CustomOption.Create(203, "追踪者可追踪尸体", true, trackerSpawnRate);
            trackerCorpsesTrackingCooldown = CustomOption.Create(204, "追踪者追踪尸体冷却时间", 30f, 0f, 120f, 5f, trackerCanTrackCorpses, format: "unitSeconds");
            trackerCorpsesTrackingDuration = CustomOption.Create(205, "追踪者追踪尸体持续时间", 5f, 2.5f, 30f, 2.5f, trackerCanTrackCorpses, format: "unitSeconds");

            snitchSpawnRate = new CustomRoleOption(210, "告密者", Snitch.color, 1);
            snitchLeftTasksForReveal = CustomOption.Create(211, "内鬼可在告密者剩余几个任务时看见告密者", 1f, 0f, 5f, 1f, snitchSpawnRate);
            snitchIncludeTeamJackal = CustomOption.Create(212, "告密者可看到豺狼团队", false, snitchSpawnRate);
            snitchTeamJackalUseDifferentArrowColor = CustomOption.Create(213, "告密者看到豺狼团队使用不同颜色箭头", true, snitchIncludeTeamJackal);

            spySpawnRate = new CustomRoleOption(240, "卧底", Spy.color, 1);
            spyCanDieToSheriff = CustomOption.Create(241, "警长可杀死卧底", false, spySpawnRate);
            spyImpostorsCanKillAnyone = CustomOption.Create(242, "含有卧底内鬼可杀死任何人", true, spySpawnRate);
            spyCanEnterVents = CustomOption.Create(243, "卧底可跳管道", false, spySpawnRate);
            spyHasImpostorVision = CustomOption.Create(244, "卧底拥有内鬼视野", false, spySpawnRate);

            securityGuardSpawnRate = new CustomRoleOption(280, "保安", SecurityGuard.color, 1);
            securityGuardCooldown = CustomOption.Create(281, "保安技能冷却", 30f, 2.5f, 60f, 2.5f, securityGuardSpawnRate, format: "unitSeconds");
            securityGuardTotalScrews = CustomOption.Create(282, "保安钉子总数", 7f, 1f, 15f, 1f, securityGuardSpawnRate, format: "unitScrews");
            securityGuardCamPrice = CustomOption.Create(283, "放置一个摄像头所需钉子", 2f, 1f, 15f, 1f, securityGuardSpawnRate, format: "unitScrews");
            securityGuardVentPrice = CustomOption.Create(284, "封锁一个管道所需钉子", 1f, 1f, 15f, 1f, securityGuardSpawnRate, format: "unitScrews");
            securityGuardCamDuration = CustomOption.Create(285, "保安远程查看监控秒数", 10f, 2.5f, 60f, 2.5f, securityGuardSpawnRate, format: "unitSeconds");
            securityGuardCamMaxCharges = CustomOption.Create(286, "保安最多远程查看监控次数", 5f, 1f, 30f, 1f, securityGuardSpawnRate);
            securityGuardCamRechargeTasksNumber = CustomOption.Create(287, "保安完成多少任务可填满远程设备使用次数", 3f, 1f, 10f, 1f, securityGuardSpawnRate);
            securityGuardNoMove = CustomOption.Create(288, "保安远程查看监控时不能移动", true, securityGuardSpawnRate);

            baitSpawnRate = new CustomRoleOption(330, "诱饵", Bait.color, 1);
            baitHighlightAllVents = CustomOption.Create(331, "管道内有人时诱饵可看到所有管道有黄光", false, baitSpawnRate);
            baitReportDelay = CustomOption.Create(332, "诱饵死亡报告延迟", 0f, 0f, 10f, 1f, baitSpawnRate, format: "unitSeconds");
            baitShowKillFlash = CustomOption.Create(333, "凶手杀死诱饵时有闪光", true, baitSpawnRate);

            mediumSpawnRate = new CustomRoleOption(370, "通灵师", Medium.color, 1);
            mediumCooldown = CustomOption.Create(371, "通灵师冷却时间", 30f, 5f, 120f, 5f, mediumSpawnRate, format: "unitSeconds");
            mediumDuration = CustomOption.Create(372, "通灵所需时间", 3f, 0f, 15f, 1f, mediumSpawnRate, format: "unitSeconds");
            mediumOneTimeUse = CustomOption.Create(373, "一个尸体仅可以通灵一次", false, mediumSpawnRate);

            // Other options
            specialOptions = new CustomOptionBlank(null);
            maxNumberOfMeetings = CustomOption.Create(3, "最大会议次数(忽略市长会议)", 10, 0, 15, 1, specialOptions, true);
            blockSkippingInEmergencyMeetings = CustomOption.Create(4, "会议中不可跳过投票", false, specialOptions);
            noVoteIsSelfVote = CustomOption.Create(5, "不投票就是自我投票", false, specialOptions);
            hideOutOfSightNametags = CustomOption.Create(550, "隐藏名牌", false, specialOptions);
            allowParallelMedBayScans = CustomOption.Create(540, "医务室支持多人同时扫描", false, specialOptions);
            hideSettings = CustomOption.Create(520, "隐藏特殊设置", false, specialOptions);

            restrictDevices = CustomOption.Create(510, "restrictDevices", new string[] { "关闭", "在每回合限制", "在每局游戏限制" }, specialOptions);
            restrictAdmin = CustomOption.Create(501, "限制管理室地图", 30f, 0f, 600f, 5f, restrictDevices, format: "unitSeconds");
            restrictCameras = CustomOption.Create(502, "限制监控", 30f, 0f, 600f, 5f, restrictDevices, format: "unitSeconds");
            restrictVents = CustomOption.Create(503, "限制心电图", 30f, 0f, 600f, 5f, restrictDevices, format: "unitSeconds");

            uselessOptions = CustomOption.Create(530, "使用较少设置", false, null, isHeader: true);
            dynamicMap = CustomOption.Create(8, "游玩随机地图", false, uselessOptions);
            dynamicMapEnableSkeld = CustomOption.Create(531, "可能随机至Skeld地图", true, dynamicMap, false);
            dynamicMapEnableMira = CustomOption.Create(532, "可能随机至米拉总部地图", true, dynamicMap, false);
            dynamicMapEnablePolus = CustomOption.Create(533, "可能随机至Polus地图", true, dynamicMap, false);
            dynamicMapEnableAirShip = CustomOption.Create(534, "可能随机至飞艇地图", true, dynamicMap, false);
            dynamicMapEnableDleks = CustomOption.Create(535, "可能随机至Dleks地图", false, dynamicMap, false);
			
            disableVents = CustomOption.Create(504, "禁用风管", false, uselessOptions);
            hidePlayerNames = CustomOption.Create(6, "隐藏玩家名字", false, uselessOptions);
            playerNameDupes = CustomOption.Create(522, "允许重复名称", false, uselessOptions);
            playerColorRandom = CustomOption.Create(521, "玩家随机颜色", false, uselessOptions);

            blockedRolePairings.Add((byte)RoleType.Vampire, new [] { (byte)RoleType.Warlock});
            blockedRolePairings.Add((byte)RoleType.Warlock, new [] { (byte)RoleType.Vampire});
            blockedRolePairings.Add((byte)RoleType.Spy, new [] { (byte)RoleType.Mini});
            blockedRolePairings.Add((byte)RoleType.Mini, new [] { (byte)RoleType.Spy});
            blockedRolePairings.Add((byte)RoleType.Vulture, new [] { (byte)RoleType.Cleaner});
            blockedRolePairings.Add((byte)RoleType.Cleaner, new [] { (byte)RoleType.Vulture});
        }
    }

}
