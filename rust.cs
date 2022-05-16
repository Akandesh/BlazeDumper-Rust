using System;
namespace blazedumper {
    public static class BaseCombatEntity
    {
        public const Int32 ShowHealthInfo = 0x218;
        public const Int32 __menuOption_Menu_Pickup = 0x160;
        public const Int32 _health = 0x224;
        public const Int32 _maxHealth = 0x228;
        public const Int32 baseProtection = 0x1C0;
        public const Int32 deathTime = 0x230;
        public const Int32 faction = 0x22C;
        public const Int32 lastNotifyFrame = 0x234;
        public const Int32 lifestate = 0x21C;
        public const Int32 markAttackerHostile = 0x222;
        public const Int32 pickup = 0x1D0;
        public const Int32 repair = 0x1F0;
        public const Int32 sendsHitNotification = 0x220;
        public const Int32 sendsMeleeHitNotification = 0x221;
        public const Int32 skeletonProperties = 0x1B8;
        public const Int32 startHealth = 0x1C8;
    }
    public static class BaseEntity
    {
        public const Int32 HasBrain = 0x148;
        public const Int32 OwnerID = 0x158;
        public const Int32 Weight = 0xF8;
        public const Int32 _name = 0x150;
        public const Int32 _pendingFileRequestsList = 0xA0;
        public const Int32 addedToParentEntity = 0xB0;
        public const Int32 bounds = 0xFC;
        public const Int32 broadcastProtocol = 0x88;
        public const Int32 enableSaving = 0x120;
        public const Int32 flags = 0x130;
        public const Int32 impactEffect = 0x118;
        public const Int32 isAnimatorVisible = 0xD1;
        public const Int32 isShadowVisible = 0xD2;
        public const Int32 isVisible = 0xD0;
        public const Int32 itemSkin = 0xB8;
        public const Int32 linkedToNeighbours = 0x98;
        public const Int32 linksList = 0x90;
        public const Int32 localOccludee = 0xD8;
        public const Int32 menuOptionsList = 0x80;
        public const Int32 model = 0x128;
        public const Int32 parentBone = 0x134;
        public const Int32 ragdoll = 0x70;
        public const Int32 skinID = 0x138;
        public const Int32 syncPosition = 0x121;
        public const Int32 triggersList = 0xC8;
        public const Int32 updateParentingAction = 0xA8;
    }
    public static class BaseEntity_TypeInfo
    {
    public const Int32 offset = 0x52240584;
    }
    public static class BasePlayer
    {
        public const Int32 Belt = 0x6B0;
        public const Int32 ClientCurrentDeathNote = 0x5D8;
        public const Int32 ClientCurrentMapNote = 0x5D0;
        public const Int32 Frozen = 0x4C8;
        public const Int32 GestureViewModel = 0x530;
        public const Int32 IsWearingDiveGoggles = 0x528;
        public const Int32 PetEntity = 0x610;
        public const Int32 PetID = 0x620;
        public const Int32 PetPrefabID = 0x61C;
        public const Int32 UserIDString = 0x6C8;
        public const Int32 __menuOption_Climb = 0x238;
        public const Int32 __menuOption_Drink = 0x290;
        public const Int32 __menuOption_InviteToTeam = 0x2E8;
        public const Int32 __menuOption_Menu_AssistPlayer = 0x340;
        public const Int32 __menuOption_Menu_LootPlayer = 0x398;
        public const Int32 __menuOption_Promote = 0x3F0;
        public const Int32 __menuOption_SaltWater = 0x448;
        public const Int32 _activeMission = 0x5E8;
        public const Int32 _displayName = 0x6D8;
        public const Int32 _lastSetName = 0x6E0;
        public const Int32 _lookingAt = 0x4F8;
        public const Int32 _lookingAtCollider = 0x508;
        public const Int32 _lookingAtEntity = 0x500;
        public const Int32 activeTelephone = 0x760;
        public const Int32 blockHeldInputTimer = 0x56C;
        public const Int32 blueprints = 0x690;
        public const Int32 cachedBuildingPrivilege = 0x628;
        public const Int32 cachedBuildingPrivilegeTime = 0x624;
        public const Int32 cachedProtection = 0x738;
        public const Int32 cachedThreatLevel = 0x638;
        public const Int32 cachedWaterDrinkingPoint = 0x550;
        public const Int32 clActiveItem = 0x5C8;
        public const Int32 clientTeam = 0x598;
        public const Int32 clientTickInterval = 0x648;
        public const Int32 clientTickRate = 0x640;
        public const Int32 client_lastHelloTime = 0x588;
        public const Int32 clothingAccuracyBonus = 0x754;
        public const Int32 clothingBlocksAiming = 0x748;
        public const Int32 clothingMoveSpeedReduction = 0x74C;
        public const Int32 clothingWaterSpeedBonus = 0x750;
        public const Int32 collision = 0x4F0;
        public const Int32 currentGesture = 0x570;
        public const Int32 currentTeam = 0x590;
        public const Int32 currentViewMode = 0x4A0;
        public const Int32 debugPrevVisible = 0x660;
        public const Int32 designingAIEntity = 0x768;
        public const Int32 disabledHeldEntity = 0x578;
        public const Int32 drownEffect = 0x670;
        public const Int32 eggVision = 0x75C;
        public const Int32 equippingBlocked = 0x758;
        public const Int32 eyes = 0x680;
        public const Int32 fallDamageEffect = 0x668;
        public const Int32 gamemodeteam = 0x6D0;
        public const Int32 gestureFinishedTime = 0x568;
        public const Int32 gestureList = 0x560;
        public const Int32 input = 0x4E0;
        public const Int32 inventory = 0x688;
        public const Int32 lastClothesHash = 0x524;
        public const Int32 lastGestureCancel = 0x584;
        public const Int32 lastHeadshotSoundTime = 0x740;
        public const Int32 lastPetCommandIssuedTime = 0x618;
        public const Int32 lastPresenceTeamId = 0x5A8;
        public const Int32 lastPresenceTeamSize = 0x5B0;
        public const Int32 lastReceivedTeamTime = 0x5A0;
        public const Int32 lastReviveDirection = 0x4B4;
        public const Int32 lastRevivePoint = 0x4A8;
        public const Int32 lastSentTick = 0x650;
        public const Int32 lastSentTickTime = 0x64C;
        public const Int32 lastTimeSeen = 0x65C;
        public const Int32 lastUpdateTime = 0x634;
        public const Int32 lookingAtPoint = 0x510;
        public const Int32 lookingAtTest = 0x548;
        public const Int32 maxProjectileID = 0x630;
        public const Int32 metabolism = 0x698;
        public const Int32 missionsList = 0x5E0;
        public const Int32 modelState = 0x5F0;
        public const Int32 modifiers = 0x6A0;
        public const Int32 mounted = 0x5F8;
        public const Int32 movement = 0x4E8;
        public const Int32 needsClothesRebuild = 0x520;
        public const Int32 nextColliderRefreshTime = 0x744;
        public const Int32 nextGestureMenuOpenTime = 0x580;
        public const Int32 nextSeatSwapTime = 0x608;
        public const Int32 nextTopologyTestTime = 0x53C;
        public const Int32 nextVisThink = 0x658;
        public const Int32 playerCollider = 0x6A8;
        public const Int32 playerColliderCrawling = 0x710;
        public const Int32 playerColliderDucked = 0x6FC;
        public const Int32 playerColliderLyingDown = 0x724;
        public const Int32 playerColliderStanding = 0x6E8;
        public const Int32 playerFlags = 0x678;
        public const Int32 playerGroupKey = 0x5B8;
        public const Int32 playerGroupSizeKey = 0x5C0;
        public const Int32 playerModel = 0x4C0;
        public const Int32 playerRigidbody = 0x6B8;
        public const Int32 reputation = 0x6D4;
        public const Int32 selectedViewMode = 0x4A4;
        public const Int32 serverTickInterval = 0x644;
        public const Int32 serverTickRate = 0x63C;
        public const Int32 timeSinceUpdatedLookingAt = 0x538;
        public const Int32 useHeldTime = 0x544;
        public const Int32 usePressTime = 0x540;
        public const Int32 userID = 0x6C0;
        public const Int32 voiceRecorder = 0x4D0;
        public const Int32 voiceSpeaker = 0x4D8;
        public const Int32 wakeTime = 0x51C;
        public const Int32 wasDead = 0x523;
        public const Int32 wasSleeping = 0x521;
        public const Int32 wokeUpBefore = 0x522;
    }
    public static class BaseProjectile
    {
        public const Int32 MuzzlePoint = 0x2A8;
        public const Int32 NoiseRadius = 0x278;
        public const Int32 aimCone = 0x2E8;
        public const Int32 aimConePenaltyMax = 0x2F4;
        public const Int32 aimSway = 0x2D0;
        public const Int32 aimSwaySpeed = 0x2D4;
        public const Int32 aimconeCurve = 0x2E0;
        public const Int32 aimconePenalty = 0x320;
        public const Int32 aimconePenaltyPerShot = 0x2F0;
        public const Int32 aimconePenaltyRecoverDelay = 0x2FC;
        public const Int32 aimconePenaltyRecoverTime = 0x2F8;
        public const Int32 aiming = 0x309;
        public const Int32 ammoTypePreReload = 0x338;
        public const Int32 attackFX = 0x290;
        public const Int32 automatic = 0x288;
        public const Int32 cachedUnderground = 0x350;
        public const Int32 canUnloadAmmo = 0x2B4;
        public const Int32 createdProjectilesList = 0x358;
        public const Int32 damageScale = 0x27C;
        public const Int32 distanceScale = 0x280;
        public const Int32 fractionalReload = 0x2C0;
        public const Int32 fractionalReloadDesiredCount = 0x340;
        public const Int32 fractionalReloadNumAdded = 0x344;
        public const Int32 hasADS = 0x304;
        public const Int32 hipAimCone = 0x2EC;
        public const Int32 isCycling = 0x308;
        public const Int32 isReloading = 0x324;
        public const Int32 lastShotTime = 0x32C;
        public const Int32 manualCycle = 0x306;
        public const Int32 muzzleBrakeAttack = 0x2A0;
        public const Int32 needsCycle = 0x307;
        public const Int32 nextHeightCheckTime = 0x34C;
        public const Int32 nextReloadTime = 0x314;
        public const Int32 noAimingWhileCycling = 0x305;
        public const Int32 numShotsFired = 0x310;
        public const Int32 primaryMagazine = 0x2B8;
        public const Int32 projectileVelocityScale = 0x284;
        public const Int32 recoil = 0x2D8;
        public const Int32 reloadEndDuration = 0x2CC;
        public const Int32 reloadFractionDuration = 0x2C8;
        public const Int32 reloadPressTime = 0x330;
        public const Int32 reloadStartDuration = 0x2C4;
        public const Int32 reloadTime = 0x2B0;
        public const Int32 resetDuration = 0x30C;
        public const Int32 silencedAttack = 0x298;
        public const Int32 stancePenalty = 0x31C;
        public const Int32 stancePenaltyScale = 0x300;
        public const Int32 startReloadTime = 0x318;
        public const Int32 swaySampleTime = 0x328;
        public const Int32 triggerReady = 0x348;
        public const Int32 turretDamageScale = 0x28C;
        public const Int32 usableByTurret = 0x289;
    }
    public static class BuildingPrivledge
    {
        public const Int32 __menuOption_MenuAuthorize = 0x478;
        public const Int32 __menuOption_MenuClearList = 0x4D0;
        public const Int32 __menuOption_MenuDeauthorize = 0x528;
        public const Int32 __menuOption_Menu_MaxAuth = 0x3C8;
        public const Int32 __menuOption_Menu_RotateVM = 0x420;
        public const Int32 allowedConstructionItemsList = 0x598;
        public const Int32 authorizedPlayersList = 0x590;
        public const Int32 cachedProtectedMinutes = 0x580;
        public const Int32 cachedUpkeepCostFraction = 0x588;
        public const Int32 cachedUpkeepPeriodMinutes = 0x584;
    }
    public static class Facepunch_Input_TypeInfo
    {
    public const Int32 offset = 0x52314552;
    }
    public static class Item
    {
        public const Int32 _condition = 0x18;
        public const Int32 _maxCondition = 0x1C;
        public const Int32 amount = 0x30;
        public const Int32 busyTime = 0x38;
        public const Int32 contents = 0x78;
        public const Int32 dirty = 0x2C;
        public const Int32 flags = 0x70;
        public const Int32 fuel = 0x40;
        public const Int32 heldEntity = 0x98;
        public const Int32 info = 0x20;
        public const Int32 instanceData = 0x48;
        public const Int32 isServer = 0x44;
        public const Int32 name = 0x58;
        public const Int32 parent = 0x80;
        public const Int32 position = 0x34;
        public const Int32 removeTime = 0x3C;
        public const Int32 skin = 0x50;
        public const Int32 text = 0x60;
        public const Int32 uid = 0x28;
        public const Int32 worldEnt = 0x88;
    }
    public static class ItemContainer
    {
        public const Int32 allowedContents = 0x14;
        public const Int32 availableSlotsList = 0x20;
        public const Int32 capacity = 0x28;
        public const Int32 dirty = 0x30;
        public const Int32 entityOwner = 0x58;
        public const Int32 flags = 0x10;
        public const Int32 isServer = 0x60;
        public const Int32 itemList = 0x38;
        public const Int32 maxStackSize = 0x64;
        public const Int32 parent = 0x48;
        public const Int32 playerOwner = 0x50;
        public const Int32 temperature = 0x40;
        public const Int32 uid = 0x2C;
    }
    public static class Magazine
    {
        public const Int32 ammoType = 0x20;
        public const Int32 capacity = 0x18;
        public const Int32 contents = 0x1C;
        public const Int32 definition = 0x10;
    }
    public static class MainCamera_TypeInfo
    {
    public const Int32 offset = 0x52247536;
    }
    public static class Model
    {
        public const Int32 _lodGroup = 0x68;
        public const Int32 animator = 0x38;
        public const Int32 collision = 0x18;
        public const Int32 eyeBone = 0x30;
        public const Int32 headBone = 0x28;
        public const Int32 rootBone = 0x20;
        public const Int32 skeleton = 0x40;
    }
    public static class PlayerInventory
    {
        public const Int32 containerBelt = 0x28;
        public const Int32 containerMain = 0x20;
        public const Int32 containerWear = 0x30;
        public const Int32 crafting = 0x38;
        public const Int32 loot = 0x40;
    }
    public static class PlayerModel
    {
        public const Int32 AimAngles = 0x1F0;
        public const Int32 CinematicAnimationController = 0x160;
        public const Int32 CinematicAvatar = 0x170;
        public const Int32 CrawlToIncapacitatedGesture = 0x188;
        public const Int32 CurrentGesture = 0x198;
        public const Int32 CurrentGestureConfig = 0x2B8;
        public const Int32 DefaultAvatar = 0x168;
        public const Int32 DefaultHoldType = 0x178;
        public const Int32 FemaleSkin = 0x1A8;
        public const Int32 InCinematic = 0x2C0;
        public const Int32 InGesture = 0x2B0;
        public const Int32 IsNpc = 0x320;
        public const Int32 LegPartsList = 0x58;
        public const Int32 LookAngles = 0x200;
        public const Int32 MaleSkin = 0x1A0;
        public const Int32 SleepGesture = 0x180;
        public const Int32 StandToIncapacitatedGesture = 0x190;
        public const Int32 WorkshopHeldEntity = 0x300;
        public const Int32 _animator = 0x2D8;
        public const Int32 _currentGesture = 0x2E8;
        public const Int32 _lodGroup = 0x2E0;
        public const Int32 _multiMesh = 0x2D0;
        public const Int32 _smoothAimWeight = 0x18;
        public const Int32 _smoothVelocity = 0x1C;
        public const Int32 _smoothlookAngle = 0x20;
        public const Int32 aimEndSoundDef = 0x2A8;
        public const Int32 aimSoundDef = 0x2A0;
        public const Int32 allowMountedHeadLook = 0x2C;
        public const Int32 animatorNeedsWarmup = 0x298;
        public const Int32 blinkController = 0xB0;
        public const Int32 cachedConstructionMask = 0x2FC;
        public const Int32 cachedLeftFootNormal = 0x338;
        public const Int32 cachedLeftFootPos = 0x32C;
        public const Int32 cachedMask = 0x2F8;
        public const Int32 cachedRightFootNormal = 0x354;
        public const Int32 cachedRightFootPos = 0x348;
        public const Int32 censorshipCube = 0x80;
        public const Int32 censorshipCubeBreasts = 0x88;
        public const Int32 collision = 0x78;
        public const Int32 defaultAnimatorController = 0x2C8;
        public const Int32 extraLeanBack = 0x68;
        public const Int32 eyeController = 0xA8;
        public const Int32 hairNumber = 0x1C8;
        public const Int32 headBone = 0xA0;
        public const Int32 holdTypeLock = 0x2F0;
        public const Int32 jawBone = 0x90;
        public const Int32 lastSafeLookDir = 0x3C;
        public const Int32 leftFootBone = 0xC0;
        public const Int32 leftFootTargetPosition = 0x144;
        public const Int32 leftFootTargetRotation = 0x150;
        public const Int32 leftHandPropBone = 0xD0;
        public const Int32 leftHandTargetPosition = 0xEC;
        public const Int32 leftHandTargetRotation = 0xF8;
        public const Int32 meshNumber = 0x1C4;
        public const Int32 modelState = 0x210;
        public const Int32 mountedAnimSpeed = 0x310;
        public const Int32 mountedSpineLookWeight = 0x30C;
        public const Int32 movementSounds = 0x1D0;
        public const Int32 neckBone = 0x98;
        public const Int32 newVelocity = 0x23C;
        public const Int32 overrideSkinSeed = 0x1E8;
        public const Int32 preserveBones = 0x314;
        public const Int32 rightFootBone = 0xC8;
        public const Int32 rightFootTargetPosition = 0x128;
        public const Int32 rightFootTargetRotation = 0x134;
        public const Int32 rightHandPropBone = 0xD8;
        public const Int32 rightHandTarget = 0xE0;
        public const Int32 rightHandTargetPosition = 0x108;
        public const Int32 rightHandTargetRotation = 0x114;
        public const Int32 showSash = 0x1D8;
        public const Int32 skinColor = 0x1BC;
        public const Int32 skinNumber = 0x1C0;
        public const Int32 skinType = 0x1CC;
        public const Int32 smoothLookDir = 0x30;
        public const Int32 steeringTargetDegrees = 0x124;
        public const Int32 subsurfaceProfile = 0x1B0;
        public const Int32 tempPoseType = 0x1DC;
        public const Int32 timeInArmsMode = 0x70;
        public const Int32 timeSinceLeftFootTest = 0x328;
        public const Int32 timeSinceReactionStart = 0x324;
        public const Int32 timeSinceRightFootTest = 0x344;
        public const Int32 underwearSkin = 0x1E0;
        public const Int32 voiceVolume = 0x1B8;
        public const Int32 wasCrawling = 0x308;
        public const Int32 wasMountedRightAim = 0x2F4;
    }
} // namespace blazedumper
