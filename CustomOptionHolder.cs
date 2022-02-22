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
        public static string[] presets = new string[]{"Ԥ��1", "Ԥ��2", "Ԥ��3", "Ԥ��4", "Ԥ��5" };

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
            activateRoles = CustomOption.Create(7, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "����ԭ��ְҵ������modְҵ"), true, null, true);

            presetSelection = CustomOption.Create(0, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Ԥ��"), presets, null, true);

            // Using new id's for the options to not break compatibilty with older versions
            crewmateRolesCountMin = CustomOption.Create(300, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С��Աְҵ����"), 0f, 0f, 15f, 1f, null, true);
            crewmateRolesCountMax = CustomOption.Create(301, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С��Աְҵ����"), 0f, 0f, 15f, 1f);
            neutralRolesCountMin = CustomOption.Create(302, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С����ְҵ����"), 0f, 0f, 15f, 1f);
            neutralRolesCountMax = CustomOption.Create(303, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С����ְҵ����"), 0f, 0f, 15f, 1f);
            impostorRolesCountMin = CustomOption.Create(304, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С�ڹ�ְҵ����"), 0f, 0f, 15f, 1f);
            impostorRolesCountMax = CustomOption.Create(305, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С�ڹ�ְҵ����"), 0f, 0f, 15f, 1f);


            gmEnabled = CustomOption.Create(400, cs(GM.color, "��Ϸ������"), false, null, true);
            gmIsHost = CustomOption.Create(401, "��Ϸ������һ���Ƿ���", true, gmEnabled);
            //gmHasTasks = CustomOption.Create(402, "gmHasTasks", false, gmEnabled);
            gmCanWarp = CustomOption.Create(405, "��Ϸ�����߿�˲�Ƶ����", true, gmEnabled);
            gmCanKill = CustomOption.Create(406, "��Ϸ�����߿���ɱ��", false, gmEnabled);
            gmDiesAtStart = CustomOption.Create(404, "��Ϸ����������Ϸ��ʼʱ����", true, gmEnabled);


            mafiaSpawnRate = new CustomRoleOption(10, "���ֵ�", Janitor.color, 1);
            janitorCooldown = CustomOption.Create(11, "��๤��ȴ", 30f, 2.5f, 60f, 2.5f, mafiaSpawnRate, format : "unitSeconds");

            morphlingSpawnRate = new CustomRoleOption(20, "������", Morphling.color, 1);
            morphlingCooldown = CustomOption.Create(21, "��������ȴ", 30f, 2.5f, 60f, 2.5f, morphlingSpawnRate, format: "unitSeconds");
            morphlingDuration = CustomOption.Create(22, "���γ���ʱ��", 10f, 1f, 20f, 0.5f, morphlingSpawnRate, format: "unitSeconds");

            camouflagerSpawnRate = new CustomRoleOption(30, "������", Camouflager.color, 1);
            camouflagerCooldown = CustomOption.Create(31, "��������ȴ", 30f, 2.5f, 60f, 2.5f, camouflagerSpawnRate, format: "unitSeconds");
            camouflagerDuration = CustomOption.Create(32, "�����߳���ʱ��", 10f, 1f, 20f, 0.5f, camouflagerSpawnRate, format: "unitSeconds");
            camouflagerRandomColors = CustomOption.Create(33, "�����������ɫ", false, camouflagerSpawnRate);

            vampireSpawnRate = new CustomRoleOption(40, "��Ѫ��", Vampire.color, 1);
            vampireKillDelay = CustomOption.Create(41, "��Ѫ��ɱ���ӳ�", 10f, 1f, 20f, 1f, vampireSpawnRate, format: "unitSeconds");
            vampireCooldown = CustomOption.Create(42, "��Ѫ����ȴ", 30f, 2.5f, 60f, 2.5f, vampireSpawnRate, format: "unitSeconds");
            vampireCanKillNearGarlics = CustomOption.Create(43, "��Ѫ����ڴ�����ɱ��", true, vampireSpawnRate);

            eraserSpawnRate = new CustomRoleOption(230, "Ĩ����", Eraser.color, 1);
            eraserCooldown = CustomOption.Create(231, "Ĩ������ȴ", 30f, 5f, 120f, 5f, eraserSpawnRate, format: "unitSeconds");
            eraserCooldownIncrease = CustomOption.Create(233, "Ĩ������ȴ�ӳ�", 10f, 0f, 120f, 2.5f, eraserSpawnRate, format: "unitSeconds");
            eraserCanEraseAnyone = CustomOption.Create(232, "Ĩ���߿�Ĩ���κ���", false, eraserSpawnRate);

            tricksterSpawnRate = new CustomRoleOption(250, "ƭ��ʦ", Trickster.color, 1);
            tricksterPlaceBoxCooldown = CustomOption.Create(251, "ƭ��ʦ���þ��ź���ȴ", 10f, 2.5f, 30f, 2.5f, tricksterSpawnRate, format: "unitSeconds");
            tricksterLightsOutCooldown = CustomOption.Create(252, "ƭ��ʦϨ����ȴ", 30f, 5f, 60f, 5f, tricksterSpawnRate, format: "unitSeconds");
            tricksterLightsOutDuration = CustomOption.Create(253, "ƭ��ʦϨ�Ƴ���ʱ��", 15f, 5f, 60f, 2.5f, tricksterSpawnRate, format: "unitSeconds");

            cleanerSpawnRate = new CustomRoleOption(260, "������", Cleaner.color, 1);
            cleanerCooldown = CustomOption.Create(261, "��������ȴ", 30f, 2.5f, 60f, 2.5f, cleanerSpawnRate, format: "unitSeconds");

            warlockSpawnRate = new CustomRoleOption(270, "��ʿ", Warlock.color, 1);
            warlockCooldown = CustomOption.Create(271, "��ʿ��ȴ", 30f, 2.5f, 60f, 2.5f, warlockSpawnRate, format: "unitSeconds");
            warlockRootTime = CustomOption.Create(272, "��ʿ��ɱ�˺���ʱ��", 5f, 0f, 15f, 1f, warlockSpawnRate, format: "unitSeconds");

            bountyHunterSpawnRate = new CustomRoleOption(320, "�ͽ�����", BountyHunter.color, 1);
            bountyHunterBountyDuration = CustomOption.Create(321, "�ͽ�����Ŀ�����ʱ��", 60f, 10f, 180f, 10f, bountyHunterSpawnRate, format: "unitSeconds");
            bountyHunterReducedCooldown = CustomOption.Create(322, "�ͽ�����ɱ��Ŀ�����ȴʱ�䣨������", 2.5f, 2.5f, 30f, 2.5f, bountyHunterSpawnRate, format: "unitSeconds");
            bountyHunterPunishmentTime = CustomOption.Create(323, "�ͽ�����ɱ����Ŀ�����ȴʱ�䣨�ͷ���", 20f, 0f, 60f, 2.5f, bountyHunterSpawnRate, format: "unitSeconds");
            bountyHunterShowArrow = CustomOption.Create(324, "�ͽ����˿ɼ�Ŀ��λ�ü�ͷ", true, bountyHunterSpawnRate);
            bountyHunterArrowUpdateIntervall = CustomOption.Create(325, "�ͽ�����Ŀ��λ�ü�ͷ����λ�ü��ʱ��", 15f, 2.5f, 60f, 2.5f, bountyHunterShowArrow, format: "unitSeconds");

            witchSpawnRate = new CustomRoleOption(390, "Ů��", Witch.color, 1);
            witchCooldown = CustomOption.Create(391, "Ů��������ȴʱ��", 30f, 2.5f, 120f, 2.5f, witchSpawnRate, format: "unitSeconds");
            witchAdditionalCooldown = CustomOption.Create(392, "Ů������������ȴʱ��", 10f, 0f, 60f, 5f, witchSpawnRate, format: "unitSeconds");
            witchCanSpellAnyone = CustomOption.Create(393, "Ů�׿ɶ��κ�������", false, witchSpawnRate);
            witchSpellCastingDuration = CustomOption.Create(394, "Ů���������ʱ��", 1f, 0f, 10f, 1f, witchSpawnRate, format: "unitSeconds");
            witchTriggerBothCooldowns = CustomOption.Create(395, "Ů�������ɱ�˹�����ȴʱ��", true, witchSpawnRate);
            witchVoteSavesTargets = CustomOption.Create(396, "Ů�����󱻱���ߴ��", true, witchSpawnRate);


            ninjaSpawnRate = new CustomRoleOption(1000, "����", Ninja.color, 3);
            ninjaStealthCooldown = CustomOption.Create(1002, "����������ȴʱ��", 30f, 2.5f, 60f, 2.5f, ninjaSpawnRate, format: "unitSeconds");
            ninjaStealthDuration = CustomOption.Create(1003, "�����������ʱ��", 15f, 2.5f, 60f, 2.5f, ninjaSpawnRate, format: "unitSeconds");
            ninjaFadeTime = CustomOption.Create(1004, "���ߴ����ε����ν���ʱ��", 0.5f, 0.0f, 2.5f, 0.5f, ninjaSpawnRate, format: "unitSeconds");
            ninjaKillPenalty = CustomOption.Create(1005, "����ɱ�˺�ͷ���ȴ", 10f, 0f, 60f, 2.5f, ninjaSpawnRate, format: "unitSeconds");
            ninjaSpeedBonus = CustomOption.Create(1006, "�����ٶ�����", 125f, 50f, 200f, 5f, ninjaSpawnRate, format: "unitPercent");
            ninjaCanBeTargeted = CustomOption.Create(1007, "���߿ɱ�Ů�ױ��", true, ninjaSpawnRate);
            ninjaCanVent = CustomOption.Create(1008, "���߿����ܵ�", false, ninjaSpawnRate);

            serialKillerSpawnRate = new CustomRoleOption(1010, "����ɱ��", SerialKiller.color, 3);
            serialKillerKillCooldown = CustomOption.Create(1012, "����ɱ��ɱ��ʱ��", 15f, 2.5f, 60f, 2.5f, serialKillerSpawnRate, format: "unitSeconds");
            serialKillerSuicideTimer = CustomOption.Create(1013, "����ɱ����Ѫʱ��", 40f, 2.5f, 60f, 2.5f, serialKillerSpawnRate, format: "unitSeconds");
            serialKillerResetTimer = CustomOption.Create(1014, "�����������Ѫʱ��", true, serialKillerSpawnRate);

            nekoKabochaSpawnRate = new CustomRoleOption(1020, "����", NekoKabocha.color, 3);
            nekoKabochaRevengeCrew = CustomOption.Create(1021, "��ɱ��Աɱ��", true, nekoKabochaSpawnRate);
            nekoKabochaRevengeNeutral = CustomOption.Create(1022, "��ɱ����ɱ��", true, nekoKabochaSpawnRate);
            nekoKabochaRevengeImpostor = CustomOption.Create(1023, "��ɱ�ڹ�ɱ��", true, nekoKabochaSpawnRate);
            nekoKabochaRevengeExile = CustomOption.Create(1024, "������ʱ��ɱ", false, nekoKabochaSpawnRate);


            madmateSpawnRate = new CustomRoleOption(360, "����", Madmate.color);
            madmateCanDieToSheriff = CustomOption.Create(361, "������ɱ������", false, madmateSpawnRate);
            madmateCanEnterVents = CustomOption.Create(362, "���ӿ����ܵ�", false, madmateSpawnRate);
            madmateHasImpostorVision = CustomOption.Create(363, "�������ڹ���Ұ", false, madmateSpawnRate);
            madmateCanSabotage = CustomOption.Create(364, "���ӿ��ƻ�", false, madmateSpawnRate);
            madmateCanFixComm = CustomOption.Create(365, "���ӿ��޸�ͨѶ", true, madmateSpawnRate);

            miniSpawnRate = new CustomRoleOption(180, "���㴬Ա", Mini.color, 1);
            miniIsImpRate = CustomOption.Create(182, "�����㴬Ա���ɸ���", rates, miniSpawnRate);
            miniGrowingUpDuration = CustomOption.Create(181, "���㴬Ա����ʱ��", 400f, 100f, 1500f, 100f, miniSpawnRate, format: "unitSeconds");

            loversSpawnRate = new CustomRoleOption(50, "����", Lovers.color, 1);
            loversImpLoverRate = CustomOption.Create(51, "�ڹ��������ɸ���", rates, loversSpawnRate);
            loversNumCouples = CustomOption.Create(57, "���˶���", 1f, 1f, 7f, 1f, loversSpawnRate, format: "unitCouples");
            loversBothDie = CustomOption.Create(52, "���˹���", true, loversSpawnRate);
            loversCanHaveAnotherRole = CustomOption.Create(53, "���˿�ӵ������ְҵ", true, loversSpawnRate);
            loversSeparateTeam = CustomOption.Create(56, "����Ϊ�������", true, loversSpawnRate);
            loversTasksCount = CustomOption.Create(55, "���˻��ŵ�ʱ���������", false, loversSpawnRate);
			loversEnableChat = CustomOption.Create(54, "���˿�˽��", true, loversSpawnRate);

            guesserSpawnRate = new CustomRoleOption(310, "�Ĺ�", Guesser.color, 1);
            guesserIsImpGuesserRate = CustomOption.Create(311, "���Ĺ����ɸ���", rates, guesserSpawnRate);
            guesserSpawnBothRate = CustomOption.Create(317, "˫�Ĺָ���", rates, guesserSpawnRate);
            guesserNumberOfShots = CustomOption.Create(312, "�Ĺֲ²����", 2f, 1f, 15f, 1f, guesserSpawnRate, format: "unitShots");
            guesserOnlyAvailableRoles = CustomOption.Create(313, "�Ĺ����ֻ��ʾ����ְҵ", true, guesserSpawnRate);
            guesserHasMultipleShotsPerMeeting = CustomOption.Create(314, "�Ĺֿ��ڻ����β²�", false, guesserSpawnRate);
            guesserShowInfoInGhostChat = CustomOption.Create(315, "�����ʾ�Ĺֲ²���Ϣ", true, guesserSpawnRate);
            guesserKillsThroughShield = CustomOption.Create(316, "�Ĺ�����ҽ������", true, guesserSpawnRate);
            guesserEvilCanKillSpy = CustomOption.Create(318, "���Ĺֿɲ²��Ե�", true, guesserSpawnRate);
			guesserCantGuessSnitchIfTaksDone = CustomOption.Create(319, "���Ĺֿɲ²��������ĸ�����", true, guesserSpawnRate);

            swapperSpawnRate = new CustomRoleOption(150, "��Ʊʦ", Swapper.color, 1);
            swapperIsImpRate = CustomOption.Create(153, "а��Ʊʦ���ɸ���", rates, swapperSpawnRate);
            swapperNumSwaps = CustomOption.Create(154, "��Ʊʦ��Ʊ����", 2f, 1f, 15f, 1f, swapperSpawnRate, format: "unitTimes");
            swapperCanCallEmergency = CustomOption.Create(151, "��Ʊʦ���ٿ���������", false, swapperSpawnRate);
            swapperCanOnlySwapOthers = CustomOption.Create(152, "��Ʊʦ�����Ի�Ʊ����", false, swapperSpawnRate);

            jesterSpawnRate = new CustomRoleOption(60, "С��", Jester.color, 1);
            jesterCanCallEmergency = CustomOption.Create(61, "С����ٿ���������", true, jesterSpawnRate);
			jesterCanSabotage = CustomOption.Create(62, "С������ƻ�", true, jesterSpawnRate);
            jesterHasImpostorVision = CustomOption.Create(63, "С�����ڹ���Ұ", false, jesterSpawnRate);

            arsonistSpawnRate = new CustomRoleOption(290, "�ݻ�", Arsonist.color, 1);
            arsonistCooldown = CustomOption.Create(291, "�ݻ𷸽�����ȴ", 12.5f, 2.5f, 60f, 2.5f, arsonistSpawnRate, format: "unitSeconds");
            arsonistDuration = CustomOption.Create(292, "�ݻ𷸽���ʱ��", 3f, 0f, 10f, 1f, arsonistSpawnRate, format: "unitSeconds");
            arsonistCanBeLovers = CustomOption.Create(293, "�ݻ𷸿���Ϊ����", false, arsonistSpawnRate);

            opportunistSpawnRate = new CustomRoleOption(380, "����������", Opportunist.color);

            jackalSpawnRate = new CustomRoleOption(220, "����", Jackal.color, 1);
            jackalKillCooldown = CustomOption.Create(221, "����ɱ����ȴʱ��", 30f, 2.5f, 60f, 2.5f, jackalSpawnRate, format: "unitSeconds");
            jackalCanUseVents = CustomOption.Create(223, "���ǿ������", true, jackalSpawnRate);
            jackalAndSidekickHaveImpostorVision = CustomOption.Create(430, "���Ǻ͸���ӵ���ڹ���Ұ", false, jackalSpawnRate);
            jackalCanCreateSidekick = CustomOption.Create(224, "���ǿ���ļ����", false, jackalSpawnRate);
            jackalCreateSidekickCooldown = CustomOption.Create(222, "������ļ������ȴ", 30f, 2.5f, 60f, 2.5f, jackalCanCreateSidekick, format: "unitSeconds");
            sidekickPromotesToJackal = CustomOption.Create(225, "�������Ϊ����", false, jackalCanCreateSidekick);
            sidekickCanKill = CustomOption.Create(226, "�����ɱ��", false, jackalCanCreateSidekick);
            sidekickCanUseVents = CustomOption.Create(227, "����ɵ��ܵ�", true, jackalCanCreateSidekick);
            jackalPromotedFromSidekickCanCreateSidekick = CustomOption.Create(228, "���ǿɴ�2��", true, jackalCanCreateSidekick);
            jackalCanCreateSidekickFromImpostor = CustomOption.Create(229, "���ǿ���ļ�ڹ�", true, jackalCanCreateSidekick);

            vultureSpawnRate = new CustomRoleOption(340, "ͺ��", Vulture.color, 1);
            vultureCooldown = CustomOption.Create(341, "ͺ����ȴʱ��", 15f, 2.5f, 60f, 2.5f, vultureSpawnRate, format: "unitSeconds");
            vultureNumberToWin = CustomOption.Create(342, "ͺ�ճԼ���ʬ���ʤ", 4f, 1f, 12f, 1f, vultureSpawnRate);
            vultureCanUseVents = CustomOption.Create(343, "ͺ�տ�ʹ�ùܵ�", true, vultureSpawnRate);
            vultureShowArrows = CustomOption.Create(344, "ͺ��չʾʬ���ͷ", true, vultureSpawnRate);

            lawyerSpawnRate = new CustomRoleOption(350, "��ʦ", Lawyer.color, 1);
            lawyerTargetKnows = CustomOption.Create(351, "��ʦ֪���ͻ�", true, lawyerSpawnRate);
            lawyerWinsAfterMeetings = CustomOption.Create(352, "��ʦ���Ի������ʤ��", false, lawyerSpawnRate);
            lawyerNeededMeetings = CustomOption.Create(353, "��ʦʤ������������", 5f, 1f, 15f, 1f, lawyerWinsAfterMeetings);
            lawyerVision = CustomOption.Create(354, "��ʦ��Ұ", 1f, 0.25f, 3f, 0.25f, lawyerSpawnRate, format: "unitMultiplier");
            lawyerKnowsRole = CustomOption.Create(355, "��ʦ֪���ͻ����", false, lawyerSpawnRate);
            pursuerCooldown = CustomOption.Create(356, "�����˿հ�����ȴ", 30f, 2.5f, 60f, 2.5f, lawyerSpawnRate, format: "unitSeconds");
            pursuerBlanksNumber = CustomOption.Create(357, "�����˿հ�������", 5f, 0f, 20f, 1f, lawyerSpawnRate, format: "unitShots");

            shifterSpawnRate = new CustomRoleOption(70, "����ʦ", Shifter.color, 1);
            shifterIsNeutralRate = CustomOption.Create(72, "������Ӫ����ʦ���ɸ���", rates, shifterSpawnRate);
            shifterShiftsModifiers = CustomOption.Create(71, "shifterShiftsModifiers", false, shifterSpawnRate);
            shifterPastShifters = CustomOption.Create(73, "shifterPastShifters", false, shifterSpawnRate);

            plagueDoctorSpawnRate = new CustomRoleOption(900, "����ҽ��", PlagueDoctor.color, 1);
            plagueDoctorInfectCooldown = CustomOption.Create(901, "����ҽ����Ⱦ��ȴʱ��", 10f, 2.5f, 60f, 2.5f, plagueDoctorSpawnRate, format: "unitSeconds");
            plagueDoctorNumInfections = CustomOption.Create(902, "����ҽ���ɸ�Ⱦ����", 1f, 1f, 15, 1f, plagueDoctorSpawnRate, format: "unitPlayers");
            plagueDoctorDistance = CustomOption.Create(903, "����ҽ����Ⱦ��Χ", 1.0f, 0.25f, 5.0f, 0.25f, plagueDoctorSpawnRate, format: "unitMeters");
            plagueDoctorDuration = CustomOption.Create(904, "����ҽ����Ⱦʱ��", 5f, 1f, 30f, 1f, plagueDoctorSpawnRate, format: "unitSeconds");
            plagueDoctorImmunityTime = CustomOption.Create(905, "���������ʱ��", 10f, 1f, 30f, 1f, plagueDoctorSpawnRate, format: "unitSeconds");
            //plagueDoctorResetMeeting = CustomOption.Create(907, "plagueDoctorResetMeeting", false, plagueDoctorSpawnRate);
            plagueDoctorInfectKiller = CustomOption.Create(906, "����ҽ���ɸ�Ⱦɱ��", true, plagueDoctorSpawnRate);
            plagueDoctorWinDead = CustomOption.Create(908, "����ҽ����������ʤ��", true, plagueDoctorSpawnRate);

            mayorSpawnRate = new CustomRoleOption(80, "�г�", Mayor.color, 1);
            mayorNumVotes = CustomOption.Create(81, "�г�Ʊ��", 2f, 2f, 10f, 1f, mayorSpawnRate, format: "unitVotes");

            engineerSpawnRate = new CustomRoleOption(90, "����ʦ", Engineer.color, 1);
            engineerNumberOfFixes = CustomOption.Create(91, "����ʦ�������", 1f, 0f, 3f, 1f, engineerSpawnRate);
            engineerHighlightForImpostors = CustomOption.Create(92, "�ڹ�ɼ��ܵ�����", true, engineerSpawnRate);
            engineerHighlightForTeamJackal = CustomOption.Create(93, "�����Ŷӿɼ��ܵ�����", true, engineerSpawnRate);

            sheriffSpawnRate = new CustomRoleOption(100, "����", Sheriff.color, 15);
            sheriffCooldown = CustomOption.Create(101, "������ȴʱ��", 30f, 2.5f, 60f, 2.5f, sheriffSpawnRate, format: "unitSeconds");
            sheriffNumShots = CustomOption.Create(103, "����ɱ�˴���", 2f, 1f, 15f, 1f, sheriffSpawnRate, format: "unitShots");
            sheriffMisfireKillsTarget = CustomOption.Create(104, "����ɱ����ʱĿ��Ҳ����", false, sheriffSpawnRate);
            sheriffCanKillNeutrals = CustomOption.Create(102, "������ɱ��������Ӫ", false, sheriffSpawnRate);

            lighterSpawnRate = new CustomRoleOption(110, "ִ����", Lighter.color, 15);
            lighterModeLightsOnVision = CustomOption.Create(111, "�ƹ⿪��,���ܿ�����Ұ", 2f, 0.25f, 5f, 0.25f, lighterSpawnRate, format: "unitMultiplier");
            lighterModeLightsOffVision = CustomOption.Create(112, "�ƹ�ر�,���ܿ�����Ұ", 0.75f, 0.25f, 5f, 0.25f, lighterSpawnRate, format: "unitMultiplier");
            lighterCooldown = CustomOption.Create(113, "ִ������ȴʱ��", 30f, 5f, 120f, 5f, lighterSpawnRate, format: "unitSeconds");
            lighterDuration = CustomOption.Create(114, "ִ���˼���ʱ��", 5f, 2.5f, 60f, 2.5f, lighterSpawnRate, format: "unitSeconds");
            lighterCanSeeNinja = CustomOption.Create(115, "ִ���˿ɿ�������", true, lighterSpawnRate);

            detectiveSpawnRate = new CustomRoleOption(120, "��̽", Detective.color, 1);
            detectiveAnonymousFootprints = CustomOption.Create(121, "��̽��ӡΪ����", false, detectiveSpawnRate);
            detectiveFootprintIntervall = CustomOption.Create(122, "��̽��ӡ�������ʱ��", 0.5f, 0.25f, 10f, 0.25f, detectiveSpawnRate, format: "unitSeconds");
            detectiveFootprintDuration = CustomOption.Create(123, "��̽��ӡ����ʱ��", 5f, 0.25f, 10f, 0.25f, detectiveSpawnRate, format: "unitSeconds");
            detectiveReportNameDuration = CustomOption.Create(124, "��̽�ڼ����ڿɿ�����������", 0, 0, 60, 2.5f, detectiveSpawnRate, format: "unitSeconds");
            detectiveReportColorDuration = CustomOption.Create(125, "��̽�ڼ����ڿɿ���������ɫ����", 20, 0, 120, 2.5f, detectiveSpawnRate, format: "unitSeconds");

            timeMasterSpawnRate = new CustomRoleOption(130, "ʱ��֮��", TimeMaster.color, 1);
            timeMasterCooldown = CustomOption.Create(131, "ʱ��֮��ʱ��֮����ȴ", 30f, 2.5f, 120f, 2.5f, timeMasterSpawnRate, format: "unitSeconds");
            timeMasterRewindTime = CustomOption.Create(132, "ʱ��֮������ʱ��", 3f, 1f, 10f, 1f, timeMasterSpawnRate, format: "unitSeconds");
            timeMasterShieldDuration = CustomOption.Create(133, "ʱ��֮��ʱ��֮��ʱ��", 3f, 1f, 20f, 1f, timeMasterSpawnRate, format: "unitSeconds");

            medicSpawnRate = new CustomRoleOption(140, "ҽ��", Medic.color, 1);
            medicShowShielded = CustomOption.Create(143, "�ɼ���", new string[] { "������", "ҽ���ͱ��϶���", "ҽ��" }, medicSpawnRate);
            medicShowAttemptToShielded = CustomOption.Create(144, "���϶���ҿɼ�ıɱ��ͼ", false, medicSpawnRate);
            medicSetShieldAfterMeeting = CustomOption.Create(145, "���ڻ������Ч", false, medicSpawnRate);
            medicShowAttemptToMedic = CustomOption.Create(146, "ҽ���ɼ�ıɱ��ͼ", false, medicSpawnRate);

            seerSpawnRate = new CustomRoleOption(160, "��ý", Seer.color, 1);
            seerMode = CustomOption.Create(161, "ģʽ", new string[] { "��������+���", "��������", "���" }, seerSpawnRate);
            seerLimitSoulDuration = CustomOption.Create(163, "��ý�������ʱ��������", false, seerSpawnRate);
            seerSoulDuration = CustomOption.Create(162, "��ý�������ʱ��", 15f, 0f, 120f, 5f, seerLimitSoulDuration, format: "unitSeconds");

            hackerSpawnRate = new CustomRoleOption(170, "�ڿ�", Hacker.color, 1);
            hackerCooldown = CustomOption.Create(171, "�ڿͺ�����ȴ", 30f, 5f, 60f, 5f, hackerSpawnRate, format: "unitSeconds");
            hackerHackeringDuration = CustomOption.Create(172, "�ڿͺ���ʱ��", 10f, 2.5f, 60f, 2.5f, hackerSpawnRate, format: "unitSeconds");
            hackerOnlyColorType = CustomOption.Create(173, "�ڿͽ��ܿ�����ɫ��ǳ", false, hackerSpawnRate);
            hackerToolsNumber = CustomOption.Create(174, "�ڿ����鿴�ƶ����ߴ���", 5f, 1f, 30f, 1f, hackerSpawnRate);
            hackerRechargeTasksNumber = CustomOption.Create(175, "�ڿ���ɶ������������Զ���豸ʹ�ô���", 2f, 1f, 5f, 1f, hackerSpawnRate);
            hackerNoMove = CustomOption.Create(176, "�ڿͺ���ʱ�����ƶ�", true, hackerSpawnRate);

            trackerSpawnRate = new CustomRoleOption(200, "׷����", Tracker.color, 1);
            trackerUpdateIntervall = CustomOption.Create(201, "׷����Ŀ���ͷ���¼��", 5f, 2.5f, 30f, 2.5f, trackerSpawnRate, format: "unitSeconds");
            trackerResetTargetAfterMeeting = CustomOption.Create(202, "׷�����ڻ�������ü�ͷ", false, trackerSpawnRate);
            trackerCanTrackCorpses = CustomOption.Create(203, "׷���߿�׷��ʬ��", true, trackerSpawnRate);
            trackerCorpsesTrackingCooldown = CustomOption.Create(204, "׷����׷��ʬ����ȴʱ��", 30f, 0f, 120f, 5f, trackerCanTrackCorpses, format: "unitSeconds");
            trackerCorpsesTrackingDuration = CustomOption.Create(205, "׷����׷��ʬ�����ʱ��", 5f, 2.5f, 30f, 2.5f, trackerCanTrackCorpses, format: "unitSeconds");

            snitchSpawnRate = new CustomRoleOption(210, "������", Snitch.color, 1);
            snitchLeftTasksForReveal = CustomOption.Create(211, "�ڹ���ڸ�����ʣ�༸������ʱ����������", 1f, 0f, 5f, 1f, snitchSpawnRate);
            snitchIncludeTeamJackal = CustomOption.Create(212, "�����߿ɿ��������Ŷ�", false, snitchSpawnRate);
            snitchTeamJackalUseDifferentArrowColor = CustomOption.Create(213, "�����߿��������Ŷ�ʹ�ò�ͬ��ɫ��ͷ", true, snitchIncludeTeamJackal);

            spySpawnRate = new CustomRoleOption(240, "�Ե�", Spy.color, 1);
            spyCanDieToSheriff = CustomOption.Create(241, "������ɱ���Ե�", false, spySpawnRate);
            spyImpostorsCanKillAnyone = CustomOption.Create(242, "�����Ե��ڹ��ɱ���κ���", true, spySpawnRate);
            spyCanEnterVents = CustomOption.Create(243, "�Ե׿����ܵ�", false, spySpawnRate);
            spyHasImpostorVision = CustomOption.Create(244, "�Ե�ӵ���ڹ���Ұ", false, spySpawnRate);

            securityGuardSpawnRate = new CustomRoleOption(280, "����", SecurityGuard.color, 1);
            securityGuardCooldown = CustomOption.Create(281, "����������ȴ", 30f, 2.5f, 60f, 2.5f, securityGuardSpawnRate, format: "unitSeconds");
            securityGuardTotalScrews = CustomOption.Create(282, "������������", 7f, 1f, 15f, 1f, securityGuardSpawnRate, format: "unitScrews");
            securityGuardCamPrice = CustomOption.Create(283, "����һ������ͷ���趤��", 2f, 1f, 15f, 1f, securityGuardSpawnRate, format: "unitScrews");
            securityGuardVentPrice = CustomOption.Create(284, "����һ���ܵ����趤��", 1f, 1f, 15f, 1f, securityGuardSpawnRate, format: "unitScrews");
            securityGuardCamDuration = CustomOption.Create(285, "����Զ�̲鿴�������", 10f, 2.5f, 60f, 2.5f, securityGuardSpawnRate, format: "unitSeconds");
            securityGuardCamMaxCharges = CustomOption.Create(286, "�������Զ�̲鿴��ش���", 5f, 1f, 30f, 1f, securityGuardSpawnRate);
            securityGuardCamRechargeTasksNumber = CustomOption.Create(287, "������ɶ������������Զ���豸ʹ�ô���", 3f, 1f, 10f, 1f, securityGuardSpawnRate);
            securityGuardNoMove = CustomOption.Create(288, "����Զ�̲鿴���ʱ�����ƶ�", true, securityGuardSpawnRate);

            baitSpawnRate = new CustomRoleOption(330, "�ն�", Bait.color, 1);
            baitHighlightAllVents = CustomOption.Create(331, "�ܵ�������ʱ�ն��ɿ������йܵ��лƹ�", false, baitSpawnRate);
            baitReportDelay = CustomOption.Create(332, "�ն����������ӳ�", 0f, 0f, 10f, 1f, baitSpawnRate, format: "unitSeconds");
            baitShowKillFlash = CustomOption.Create(333, "����ɱ���ն�ʱ������", true, baitSpawnRate);

            mediumSpawnRate = new CustomRoleOption(370, "ͨ��ʦ", Medium.color, 1);
            mediumCooldown = CustomOption.Create(371, "ͨ��ʦ��ȴʱ��", 30f, 5f, 120f, 5f, mediumSpawnRate, format: "unitSeconds");
            mediumDuration = CustomOption.Create(372, "ͨ������ʱ��", 3f, 0f, 15f, 1f, mediumSpawnRate, format: "unitSeconds");
            mediumOneTimeUse = CustomOption.Create(373, "һ��ʬ�������ͨ��һ��", false, mediumSpawnRate);

            // Other options
            specialOptions = new CustomOptionBlank(null);
            maxNumberOfMeetings = CustomOption.Create(3, "���������(�����г�����)", 10, 0, 15, 1, specialOptions, true);
            blockSkippingInEmergencyMeetings = CustomOption.Create(4, "�����в�������ͶƱ", false, specialOptions);
            noVoteIsSelfVote = CustomOption.Create(5, "��ͶƱ��������ͶƱ", false, specialOptions);
            hideOutOfSightNametags = CustomOption.Create(550, "��������", false, specialOptions);
            allowParallelMedBayScans = CustomOption.Create(540, "ҽ����֧�ֶ���ͬʱɨ��", false, specialOptions);
            hideSettings = CustomOption.Create(520, "������������", false, specialOptions);

            restrictDevices = CustomOption.Create(510, "restrictDevices", new string[] { "�ر�", "��ÿ�غ�����", "��ÿ����Ϸ����" }, specialOptions);
            restrictAdmin = CustomOption.Create(501, "���ƹ����ҵ�ͼ", 30f, 0f, 600f, 5f, restrictDevices, format: "unitSeconds");
            restrictCameras = CustomOption.Create(502, "���Ƽ��", 30f, 0f, 600f, 5f, restrictDevices, format: "unitSeconds");
            restrictVents = CustomOption.Create(503, "�����ĵ�ͼ", 30f, 0f, 600f, 5f, restrictDevices, format: "unitSeconds");

            uselessOptions = CustomOption.Create(530, "ʹ�ý�������", false, null, isHeader: true);
            dynamicMap = CustomOption.Create(8, "���������ͼ", false, uselessOptions);
            dynamicMapEnableSkeld = CustomOption.Create(531, "���������Skeld��ͼ", true, dynamicMap, false);
            dynamicMapEnableMira = CustomOption.Create(532, "��������������ܲ���ͼ", true, dynamicMap, false);
            dynamicMapEnablePolus = CustomOption.Create(533, "���������Polus��ͼ", true, dynamicMap, false);
            dynamicMapEnableAirShip = CustomOption.Create(534, "�����������ͧ��ͼ", true, dynamicMap, false);
            dynamicMapEnableDleks = CustomOption.Create(535, "���������Dleks��ͼ", false, dynamicMap, false);
			
            disableVents = CustomOption.Create(504, "���÷��", false, uselessOptions);
            hidePlayerNames = CustomOption.Create(6, "�����������", false, uselessOptions);
            playerNameDupes = CustomOption.Create(522, "�����ظ�����", false, uselessOptions);
            playerColorRandom = CustomOption.Create(521, "��������ɫ", false, uselessOptions);

            blockedRolePairings.Add((byte)RoleType.Vampire, new [] { (byte)RoleType.Warlock});
            blockedRolePairings.Add((byte)RoleType.Warlock, new [] { (byte)RoleType.Vampire});
            blockedRolePairings.Add((byte)RoleType.Spy, new [] { (byte)RoleType.Mini});
            blockedRolePairings.Add((byte)RoleType.Mini, new [] { (byte)RoleType.Spy});
            blockedRolePairings.Add((byte)RoleType.Vulture, new [] { (byte)RoleType.Cleaner});
            blockedRolePairings.Add((byte)RoleType.Cleaner, new [] { (byte)RoleType.Vulture});
        }
    }

}
