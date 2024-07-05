using System;
namespace blazedumper {
    public static class BaseEntity_TypeInfo
    {
        public const Int32 offset = 0x3C72B20;
    }
    public static class Facepunch_Input_TypeInfo
    {
        public const Int32 offset = 0x3C46928;
    }
    public static class MainCamera_TypeInfo
    {
        public const Int32 offset = 0x3C5EEE8;
    }
    public static class System_Collections_Generic_List_BaseGameMode_TypeInfo
    {
        public const Int32 offset = 0x3CA1ED0;
    }
    public static class ConVar_Admin_TypeInfo
    {
        public const Int32 offset = 0x3C67A98;
    }
    public static class BaseGameMode_TypeInfo
    {
        public const Int32 offset = 0x3C72D90;
    }
    public static class TOD_Sky_TypeInfo
    {
        public const Int32 offset = 0x3C314C0;
    }
    public static class ConsoleSystem_Index_TypeInfo
    {
        public const Int32 offset = 0x3C72D50;
    }
    public static class BasePlayer_TypeInfo
    {
        public const Int32 offset = 0x3C73B60;
    }
    public static class ConVar_Graphics_TypeInfo
    {
        public const Int32 offset = 0x3C28788;
    }
    public static class OcclusionCulling_TypeInfo
    {
        public const Int32 offset = 0x3C73E18;
    }
    public static class BaseNetworkable_TypeInfo
    {
        public const Int32 offset = 0x3C73750;
    }
    public static class BasePlayer
    {
        public const Int32 __menuOption_Climb = 0x290; // Option
        public const Int32 __menuOption_Drink = 0x308; // Option
        public const Int32 __menuOption_InviteToClan = 0x380; // Option
        public const Int32 __menuOption_InviteToTeam = 0x3F8; // Option
        public const Int32 __menuOption_Menu_AssistPlayer = 0x470; // Option
        public const Int32 __menuOption_Menu_ForceMountHood = 0x4E8; // Option
        public const Int32 __menuOption_Menu_ForceSwapSeat = 0x560; // Option
        public const Int32 __menuOption_Menu_LootPlayer = 0x5D8; // Option
        public const Int32 __menuOption_Menu_Push = 0x650; // Option
        public const Int32 __menuOption_Menu_RemoveCuffs = 0x6C8; // Option
        public const Int32 __menuOption_Menu_RemoveHood = 0x740; // Option
        public const Int32 __menuOption_SaltWater = 0x7B8; // Option
        public const Int32 clanId = 0x830; // long
        public const Int32 playerModel = 0x838; // PlayerModel
        public const Int32 Frozen = 0x840; // bool
        public const Int32 LookLocked = 0x841; // bool
        public const Int32 voiceRecorder = 0x848; // PlayerVoiceRecorder
        public const Int32 voiceSpeaker = 0x850; // PlayerVoiceSpeaker
        public const Int32 input = 0x858; // PlayerInput
        public const Int32 movement = 0x860; // BaseMovement
        public const Int32 collision = 0x868; // BaseCollision
        public const Int32 bagCount = 0x870; // int
        public const Int32 shelterCount = 0x874; // int
        public const Int32 modelInitUnderwear = 0x878; // uint
        public const Int32 _lookingAt = 0x880; // GameObject
        public const Int32 _lookingAtEntity = 0x888; // BaseEntity
        public const Int32 _lookingAtCollider = 0x890; // Collider
        public const Int32 lookingAtPoint = 0x898; // Vector3
        public const Int32 wakeTime = 0x8A4; // float
        public const Int32 needsClothesRebuild = 0x8A8; // bool
        public const Int32 wasSleeping = 0x8A9; // bool
        public const Int32 wokeUpBefore = 0x8AA; // bool
        public const Int32 wasDead = 0x8AB; // bool
        public const Int32 HasMountedClothing = 0x8AC; // bool
        public const Int32 HasWearableClothing = 0x8AD; // bool
        public const Int32 lastClothesHash = 0x8B0; // uint
        public const Int32 lastOpenSoundPlay = 0x8B4; // TimeSince
        public const Int32 currentViewMode = 0x8B8; // BasePlayer.CameraMode
        public const Int32 selectedViewMode = 0x8BC; // BasePlayer.CameraMode
        public const Int32 lastRevivePoint = 0x8C0; // Vector3
        public const Int32 lastReviveDirection = 0x8CC; // Vector3
        public const Int32 IsWearingDiveGoggles = 0x8D8; // bool
        public const Int32 GestureViewModel = 0x8E0; // ViewModel
        public const Int32 currentClientRespawnInformation = 0x8E8; // RespawnInformation
        public const Int32 respawnOptionsTimestamp = 0x8F0; // float
        public const Int32 lastParachuteRequest = 0x8F4; // TimeSince
        public const Int32 timeSinceUpdatedLookingAt = 0x8F8; // RealTimeSince
        public const Int32 nextTopologyTestTime = 0x8FC; // float
        public const Int32 usePressTime = 0x900; // float
        public const Int32 useHeldTime = 0x904; // float
        public const Int32 lookingAtTest = 0x908; // HitTest
        public const Int32 cachedWaterDrinkingPoint = 0x910; // Vector3
        public const Int32 hasRequestedServerEmoji = 0x91C; // bool
        public const Int32 gestureList = 0x930; // GestureCollection
        public const Int32 gestureFinishedTime = 0x938; // TimeUntil
        public const Int32 blockHeldInputTimer = 0x93C; // TimeSince
        public const Int32 currentGesture = 0x940; // GestureConfig
        public const Int32 disabledHeldEntity = 0x948; // HeldEntity
        public const Int32 nextGestureMenuOpenTime = 0x950; // float
        public const Int32 client_lastHelloTime = 0x954; // float
        public const Int32 currentTeam = 0x958; // ulong
        public const Int32 clientTeam = 0x960; // PlayerTeam
        public const Int32 lastReceivedTeamTime = 0x970; // float
        public const Int32 lastPresenceTeamId = 0x978; // ulong
        public const Int32 lastPresenceTeamSize = 0x980; // int
        public const Int32 playerGroupKey = 0x988; // string
        public const Int32 playerGroupSizeKey = 0x990; // string
        public const Int32 clActiveItem = 0x998; // ItemId
        public const Int32 ClientCurrentMapNotes = 0x9A0; // List<MapNote>
        public const Int32 ClientCurrentDeathNote = 0x9A8; // MapNote
        public const Int32 keepOpenMapInterface = 0x9B0; // bool
        public const Int32 missions = 0x9B8; // List<BaseMission.MissionInstance>
        public const Int32 _activeMission = 0x9C0; // int
        public const Int32 modelState = 0x9C8; // ModelState
        public const Int32 mounted = 0x9D0; // EntityRef
        public const Int32 nextSeatSwapTime = 0x9E0; // float
        public const Int32 mountInputHeldDuringDismount = 0x9E4; // bool
        public const Int32 PetEntity = 0x9E8; // BaseEntity
        public const Int32 lastPetCommandIssuedTime = 0x9F0; // float
        public const Int32 PetPrefabID = 0x9F4; // uint
        public const Int32 PetID = 0x9F8; // NetworkableId
        public const Int32 ClientCurrentPings = 0xA00; // List<MapNote>
        public const Int32 tapInProcess = 0xA08; // bool
        public const Int32 lastPingTap = 0xA0C; // TimeSince
        public const Int32 cachedBuildingPrivilegeTime = 0xA10; // float
        public const Int32 cachedBuildingPrivilege = 0xA18; // BuildingPrivlidge
        public const Int32 cachedVehicleBuildingBlockedTime = 0xA20; // float
        public const Int32 cachedVehicleBuildingBlocked = 0xA24; // bool
        public const Int32 cachedEntityBuildingBlockedTime = 0xA28; // float
        public const Int32 cachedEntityBuildingBlocked = 0xA2C; // bool
        public const Int32 cachedPrivilegeFromOther = 0xA30; // BaseEntity
        public const Int32 cachedPrivilegeFromOtherTime = 0xA38; // float
        public const Int32 maxProjectileID = 0xA3C; // int
        public const Int32 lastSpectateCameraUpdate = 0xA40; // TimeSince
        public const Int32 lastUpdateTime = 0xA44; // float
        public const Int32 cachedThreatLevel = 0xA48; // float
        public const Int32 lastSentTickTime = 0xA4C; // float
        public const Int32 lastTickStopwatch = 0xA50; // Stopwatch
        public const Int32 lastSentTick = 0xA58; // PlayerTick
        public const Int32 CurrentTutorialAllowance = 0xA60; // BasePlayer.TutorialItemAllowance
        public const Int32 startTutorialCooldown = 0xA64; // float
        public const Int32 nextVisThink = 0xA68; // float
        public const Int32 lastTimeSeen = 0xA6C; // float
        public const Int32 debugPrevVisible = 0xA70; // bool
        public const Int32 fallDamageEffect = 0xA78; // GameObjectRef
        public const Int32 drownEffect = 0xA80; // GameObjectRef
        public const Int32 playerFlags = 0xA88; // BasePlayer.PlayerFlags
        public const Int32 eyes = 0xA90; // PlayerEyes
        public const Int32 inventory = 0xA98; // PlayerInventory
        public const Int32 blueprints = 0xAA0; // PlayerBlueprints
        public const Int32 metabolism = 0xAA8; // PlayerMetabolism
        public const Int32 modifiers = 0xAB0; // PlayerModifiers
        public const Int32 playerCollider = 0xAB8; // CapsuleCollider
        public const Int32 Belt = 0xAC0; // PlayerBelt
        public const Int32 playerRigidbody = 0xAC8; // Rigidbody
        public const Int32 userID = 0xAD0; // ulong
        public const Int32 UserIDString = 0xAD8; // string
        public const Int32 gamemodeteam = 0xAE0; // int
        public const Int32 reputation = 0xAE4; // int
        public const Int32 _displayName = 0xAE8; // string
        public const Int32 _lastSetName = 0xAF0; // string
        public const Int32 playerColliderStanding = 0xAF8; // BasePlayer.CapsuleColliderInfo
        public const Int32 playerColliderDucked = 0xB0C; // BasePlayer.CapsuleColliderInfo
        public const Int32 playerColliderCrawling = 0xB20; // BasePlayer.CapsuleColliderInfo
        public const Int32 playerColliderLyingDown = 0xB34; // BasePlayer.CapsuleColliderInfo
        public const Int32 cachedProtection = 0xB48; // ProtectionProperties
        public const Int32 lastHeadshotSoundTime = 0xB50; // float
        public const Int32 nextColliderRefreshTime = 0xB54; // float
        public const Int32 weaponMoveSpeedScale = 0xB58; // float
        public const Int32 clothingBlocksAiming = 0xB5C; // bool
        public const Int32 clothingMoveSpeedReduction = 0xB60; // float
        public const Int32 clothingWaterSpeedBonus = 0xB64; // float
        public const Int32 clothingAccuracyBonus = 0xB68; // float
        public const Int32 equippingBlocked = 0xB6C; // bool
        public const Int32 eggVision = 0xB70; // float
        public const Int32 activeTelephone = 0xB78; // PhoneController
        public const Int32 designingAIEntity = 0xB80; // BaseEntity
    }
    public static class BaseEntity
    {
        public const Int32 ragdoll = 0x80; // Ragdoll
        public const Int32 positionLerp = 0x88; // PositionLerp
        public const Int32 ClientNetworkTime = 0x90; // float
        public const Int32 menuOptions = 0x98; // List<Option>
        public const Int32 bounds = 0xA0; // Bounds
        public const Int32 impactEffect = 0xB8; // GameObjectRef
        public const Int32 enableSaving = 0xC0; // bool
        public const Int32 syncPosition = 0xC1; // bool
        public const Int32 model = 0xC8; // Model
        public const Int32 flags = 0xD0; // BaseEntity.Flags
        public const Int32 parentBone = 0xD4; // uint
        public const Int32 skinID = 0xD8; // ulong
        public const Int32 _components = 0xE0; // EntityComponentBase[]
        public const Int32 HasBrain = 0xE8; // bool
        public const Int32 _name = 0xF0; // string
        public const Int32 OwnerID = 0xF8; // ulong
        public const Int32 broadcastProtocol = 0x100; // uint
        public const Int32 links = 0x108; // List<EntityLink>
        public const Int32 linkedToNeighbours = 0x110; // bool
        public const Int32 _pendingFileRequests = 0x118; // List<BaseEntity.PendingFileRequest>
        public const Int32 updateParentingAction = 0x120; // Action
        public const Int32 addedToParentEntity = 0x128; // BaseEntity
        public const Int32 itemSkin = 0x130; // ItemSkin
        public const Int32 successCallback = 0x138; // Action
        public const Int32 failureCallback = 0x140; // Action
        public const Int32 entitySlots = 0x148; // EntityRef[]
        public const Int32 triggers = 0x150; // List<TriggerBase>
        public const Int32 isVisible = 0x158; // bool
        public const Int32 isAnimatorVisible = 0x159; // bool
        public const Int32 isShadowVisible = 0x15A; // bool
        public const Int32 localOccludee = 0x160; // OccludeeSphere
        public const Int32 Weight = 0x180; // float
    }
    public static class BaseCombatEntity
    {
        public const Int32 __menuOption_Menu_Pickup = 0x188; // Option
        public const Int32 skeletonProperties = 0x200; // SkeletonProperties
        public const Int32 baseProtection = 0x208; // ProtectionProperties
        public const Int32 startHealth = 0x210; // float
        public const Int32 pickup = 0x218; // BaseCombatEntity.Pickup
        public const Int32 repair = 0x240; // BaseCombatEntity.Repair
        public const Int32 ShowHealthInfo = 0x270; // bool
        public const Int32 lifestate = 0x274; // BaseCombatEntity.LifeState
        public const Int32 sendsHitNotification = 0x278; // bool
        public const Int32 sendsMeleeHitNotification = 0x279; // bool
        public const Int32 markAttackerHostile = 0x27A; // bool
        public const Int32 _health = 0x27C; // float
        public const Int32 _maxHealth = 0x280; // float
        public const Int32 faction = 0x284; // BaseCombatEntity.Faction
        public const Int32 deathTime = 0x288; // float
        public const Int32 lastNotifyFrame = 0x28C; // int
    }
    public static class BuildingPrivlidge
    {
        public const Int32 __menuOption_Menu_AssignToFriend = 0x4A0; // Option
        public const Int32 __menuOption_Menu_MaxAuth = 0x518; // Option
        public const Int32 __menuOption_Menu_RotateVM = 0x590; // Option
        public const Int32 __menuOption_MenuAuthorize = 0x608; // Option
        public const Int32 __menuOption_MenuClearList = 0x680; // Option
        public const Int32 __menuOption_MenuDeauthorize = 0x6F8; // Option
        public const Int32 assignDialog = 0x770; // GameObject
        public const Int32 allowedConstructionItems = 0x780; // List<ItemDefinition>
        public const Int32 cachedProtectedMinutes = 0x788; // float
        public const Int32 cachedUpkeepPeriodMinutes = 0x78C; // float
        public const Int32 cachedUpkeepCostFraction = 0x790; // float
        public const Int32 clientAuthed = 0x794; // bool
        public const Int32 clientAnyAuthed = 0x795; // bool
        public const Int32 lastProtectedMinuteUpdate = 0x798; // DateTime
    }
    public static class BaseProjectile
    {
        public const Int32 NoiseRadius = 0x2A0; // float
        public const Int32 damageScale = 0x2A4; // float
        public const Int32 distanceScale = 0x2A8; // float
        public const Int32 projectileVelocityScale = 0x2AC; // float
        public const Int32 automatic = 0x2B0; // bool
        public const Int32 usableByTurret = 0x2B1; // bool
        public const Int32 turretDamageScale = 0x2B4; // float
        public const Int32 attackFX = 0x2B8; // GameObjectRef
        public const Int32 silencedAttack = 0x2C0; // GameObjectRef
        public const Int32 muzzleBrakeAttack = 0x2C8; // GameObjectRef
        public const Int32 MuzzlePoint = 0x2D0; // Transform
        public const Int32 reloadTime = 0x2D8; // float
        public const Int32 canUnloadAmmo = 0x2DC; // bool
        public const Int32 primaryMagazine = 0x2E0; // BaseProjectile.Magazine
        public const Int32 fractionalReload = 0x2E8; // bool
        public const Int32 reloadStartDuration = 0x2EC; // float
        public const Int32 reloadFractionDuration = 0x2F0; // float
        public const Int32 reloadEndDuration = 0x2F4; // float
        public const Int32 aimSway = 0x2F8; // float
        public const Int32 aimSwaySpeed = 0x2FC; // float
        public const Int32 recoil = 0x300; // RecoilProperties
        public const Int32 aimconeCurve = 0x308; // AnimationCurve
        public const Int32 aimCone = 0x310; // float
        public const Int32 hipAimCone = 0x314; // float
        public const Int32 aimconePenaltyPerShot = 0x318; // float
        public const Int32 aimConePenaltyMax = 0x31C; // float
        public const Int32 aimconePenaltyRecoverTime = 0x320; // float
        public const Int32 aimconePenaltyRecoverDelay = 0x324; // float
        public const Int32 stancePenaltyScale = 0x328; // float
        public const Int32 hasADS = 0x32C; // bool
        public const Int32 noAimingWhileCycling = 0x32D; // bool
        public const Int32 manualCycle = 0x32E; // bool
        public const Int32 needsCycle = 0x32F; // bool
        public const Int32 isCycling = 0x330; // bool
        public const Int32 aiming = 0x331; // bool
        public const Int32 useEmptyAmmoState = 0x332; // bool
        public const Int32 isBurstWeapon = 0x333; // bool
        public const Int32 canChangeFireModes = 0x334; // bool
        public const Int32 defaultOn = 0x335; // bool
        public const Int32 internalBurstRecoilScale = 0x338; // float
        public const Int32 internalBurstFireRateScale = 0x33C; // float
        public const Int32 internalBurstAimConeScale = 0x340; // float
        public const Int32 resetDuration = 0x344; // float
        public const Int32 numShotsFired = 0x348; // int
        public const Int32 nextReloadTime = 0x34C; // float
        public const Int32 startReloadTime = 0x350; // float
        public const Int32 stancePenalty = 0x354; // float
        public const Int32 aimconePenalty = 0x358; // float
        public const Int32 cachedModHash = 0x35C; // uint
        public const Int32 sightAimConeScale = 0x360; // float
        public const Int32 sightAimConeOffset = 0x364; // float
        public const Int32 hipAimConeScale = 0x368; // float
        public const Int32 hipAimConeOffset = 0x36C; // float
        public const Int32 isReloading = 0x370; // bool
        public const Int32 timeSinceReloadFinished = 0x374; // TimeSince
        public const Int32 swaySampleTime = 0x378; // float
        public const Int32 lastShotTime = 0x37C; // float
        public const Int32 reloadPressTime = 0x380; // float
        public const Int32 ammoTypePreReload = 0x388; // ItemDefinition
        public const Int32 fractionalReloadDesiredCount = 0x390; // int
        public const Int32 fractionalReloadNumAdded = 0x394; // int
        public const Int32 currentBurst = 0x398; // int
        public const Int32 triggerReady = 0x39C; // bool
        public const Int32 nextHeightCheckTime = 0x3A0; // float
        public const Int32 cachedUnderground = 0x3A4; // bool
        public const Int32 createdProjectiles = 0x3A8; // List<Projectile>
    }
    public static class Magazine
    {
        public const Int32 definition = 0x10; // BaseProjectile.Magazine.Definition
        public const Int32 capacity = 0x18; // int
        public const Int32 contents = 0x1C; // int
        public const Int32 ammoType = 0x20; // ItemDefinition
        public const Int32 allowPlayerReloading = 0x28; // bool
        public const Int32 allowAmmoSwitching = 0x29; // bool
    }
    public static class PlayerInventory
    {
        public const Int32 containerMain = 0x28; // ItemContainer
        public const Int32 containerBelt = 0x30; // ItemContainer
        public const Int32 containerWear = 0x38; // ItemContainer
        public const Int32 crafting = 0x40; // ItemCrafter
        public const Int32 loot = 0x48; // PlayerLoot
        public const Int32 lastSet = 0x50; // List<ItemIcon>
        public const Int32 cachedResult = 0x58; // PlayerInventory.WearCheckResult
        public const Int32 returnItems = 0x68; // List<Item>
    }
    public static class ItemContainer
    {
        public const Int32 flags = 0x10; // ItemContainer.Flag
        public const Int32 allowedContents = 0x14; // ItemContainer.ContentsType
        public const Int32 onlyAllowedItems = 0x18; // ItemDefinition[]
        public const Int32 availableSlots = 0x28; // List<ItemSlot>
        public const Int32 capacity = 0x30; // int
        public const Int32 uid = 0x38; // ItemContainerId
        public const Int32 dirty = 0x40; // bool
        public const Int32 itemList = 0x48; // List<Item>
        public const Int32 temperature = 0x50; // float
        public const Int32 parent = 0x58; // Item
        public const Int32 playerOwner = 0x60; // BasePlayer
        public const Int32 entityOwner = 0x68; // BaseEntity
        public const Int32 isServer = 0x70; // bool
        public const Int32 maxStackSize = 0x74; // int
        public const Int32 containerVolume = 0x78; // int
    }
    public static class PlayerModel
    {
        public const Int32 collision = 0x20; // BoxCollider
        public const Int32 censorshipCube = 0x28; // GameObject
        public const Int32 censorshipCubeBreasts = 0x30; // GameObject
        public const Int32 jawBone = 0x38; // GameObject
        public const Int32 neckBone = 0x40; // GameObject
        public const Int32 headBone = 0x48; // GameObject
        public const Int32 eyeController = 0x50; // EyeController
        public const Int32 blinkController = 0x58; // EyeBlink
        public const Int32 SpineBones = 0x60; // Transform[]
        public const Int32 leftFootBone = 0x68; // Transform
        public const Int32 rightFootBone = 0x70; // Transform
        public const Int32 leftHandPropBone = 0x78; // Transform
        public const Int32 rightHandPropBone = 0x80; // Transform
        public const Int32 rightHandTarget = 0x88; // Vector3
        public const Int32 isPreview = 0x94; // bool
        public const Int32 leftHandTargetPosition = 0x98; // Vector3
        public const Int32 leftHandTargetRotation = 0xA4; // Quaternion
        public const Int32 rightHandTargetPosition = 0xB4; // Vector3
        public const Int32 rightHandTargetRotation = 0xC0; // Quaternion
        public const Int32 steeringTargetDegrees = 0xD0; // float
        public const Int32 rightFootTargetPosition = 0xD4; // Vector3
        public const Int32 rightFootTargetRotation = 0xE0; // Quaternion
        public const Int32 leftFootTargetPosition = 0xF0; // Vector3
        public const Int32 leftFootTargetRotation = 0xFC; // Quaternion
        public const Int32 CinematicAnimationController = 0x110; // RuntimeAnimatorController
        public const Int32 DefaultAvatar = 0x118; // Avatar
        public const Int32 CinematicAvatar = 0x120; // Avatar
        public const Int32 DefaultHoldType = 0x128; // RuntimeAnimatorController
        public const Int32 SleepGesture = 0x130; // RuntimeAnimatorController
        public const Int32 CrawlToIncapacitatedGesture = 0x138; // RuntimeAnimatorController
        public const Int32 CrawlToIncapacitatedGestureHandcuff = 0x140; // RuntimeAnimatorController
        public const Int32 StandToIncapacitatedGesture = 0x148; // RuntimeAnimatorController
        public const Int32 CurrentGesture = 0x150; // RuntimeAnimatorController
        public const Int32 MaleSkin = 0x158; // SkinSetCollection
        public const Int32 FemaleSkin = 0x160; // SkinSetCollection
        public const Int32 subsurfaceProfile = 0x168; // SubsurfaceProfile
        public const Int32 voiceVolume = 0x170; // float
        public const Int32 skinColor = 0x174; // float
        public const Int32 skinNumber = 0x178; // float
        public const Int32 meshNumber = 0x17C; // float
        public const Int32 hairNumber = 0x180; // float
        public const Int32 skinType = 0x184; // int
        public const Int32 movementSounds = 0x188; // MovementSounds
        public const Int32 showSash = 0x190; // bool
        public const Int32 tempPoseType = 0x194; // int
        public const Int32 underwearSkin = 0x198; // uint
        public const Int32 overrideSkinSeed = 0x1A0; // ulong
        public const Int32 AimAngles = 0x1A8; // Quaternion
        public const Int32 LookAngles = 0x1B8; // Quaternion
        public const Int32 modelState = 0x1C8; // ModelState
        public const Int32 position = 0x1D0; // Vector3
        public const Int32 velocity = 0x1DC; // Vector3
        public const Int32 speedOverride = 0x1E8; // Vector3
        public const Int32 newVelocity = 0x1F4; // Vector3
        public const Int32 rotation = 0x200; // Quaternion
        public const Int32 mountedRotation = 0x210; // Quaternion
        public const Int32 fallingTime = 0x220; // float
        public const Int32 smoothLeftFootIK = 0x224; // Vector3
        public const Int32 smoothRightFootIK = 0x230; // Vector3
        public const Int32 drawShadowOnly = 0x23C; // bool
        public const Int32 isIncapacitated = 0x23D; // bool
        public const Int32 flinchLocation = 0x240; // uint
        public const Int32 visible = 0x244; // bool
        public const Int32 nameTag = 0x248; // PlayerNameTag
        public const Int32 animatorNeedsWarmup = 0x250; // bool
        public const Int32 isLocalPlayer = 0x251; // bool
        public const Int32 aimSoundDef = 0x258; // SoundDefinition
        public const Int32 aimEndSoundDef = 0x260; // SoundDefinition
        public const Int32 InGesture = 0x268; // bool
        public const Int32 CurrentGestureConfig = 0x270; // GestureConfig
        public const Int32 InCinematic = 0x278; // bool
        public const Int32 defaultAnimatorController = 0x280; // RuntimeAnimatorController
        public const Int32 _multiMesh = 0x288; // SkinnedMultiMesh
        public const Int32 _animator = 0x290; // Animator
        public const Int32 _lodGroup = 0x298; // LODGroup
        public const Int32 _currentGesture = 0x2A0; // RuntimeAnimatorController
        public const Int32 holdTypeLock = 0x2A8; // float
        public const Int32 hasHeldEntity = 0x2AC; // bool
        public const Int32 wasMountedRightAim = 0x2AD; // bool
        public const Int32 cachedMask = 0x2B0; // int
        public const Int32 cachedConstructionMask = 0x2B4; // int
        public const Int32 WorkshopHeldEntity = 0x2B8; // HeldEntity
        public const Int32 wasCrawling = 0x2C0; // bool
        public const Int32 mountedSpineLookWeight = 0x2C4; // float
        public const Int32 mountedAnimSpeed = 0x2C8; // float
        public const Int32 preserveBones = 0x2CC; // bool
        public const Int32 blendShapeControllers = 0x2D8; // List<BlendShapeController>
        public const Int32 suppressEyeMovement = 0x2E0; // bool
        public const Int32 isRestrained = 0x2E1; // bool
        public const Int32 IsNpc = 0x2E2; // bool
        public const Int32 timeSinceReactionStart = 0x2E4; // TimeSince
        public const Int32 timeSinceLeftFootTest = 0x2E8; // TimeSince
        public const Int32 cachedLeftFootPos = 0x2EC; // Vector3
        public const Int32 cachedLeftFootNormal = 0x2F8; // Vector3
        public const Int32 timeSinceRightFootTest = 0x304; // TimeSince
        public const Int32 cachedRightFootPos = 0x308; // Vector3
        public const Int32 cachedRightFootNormal = 0x314; // Vector3
        public const Int32 _smoothAimWeight = 0x320; // float
        public const Int32 _smoothVelocity = 0x324; // float
        public const Int32 _smoothlookAngle = 0x328; // Vector3
        public const Int32 allowMountedHeadLook = 0x334; // bool
        public const Int32 overrideLeftHandIkWeight = 0x338; // float
        public const Int32 overrideRightHandIkWeight = 0x33C; // float
        public const Int32 smoothLookDir = 0x340; // Vector3
        public const Int32 lastSafeLookDir = 0x34C; // Vector3
        public const Int32 cinematicLookAt = 0x358; // Vector3
        public const Int32 lastCinematicLookAt = 0x364; // Vector3
        public const Int32 cinematicLookAtWeight = 0x370; // float
        public const Int32 cinematicTargetWeight = 0x374; // float
        public const Int32 Shoulders = 0x378; // Transform[]
        public const Int32 AdditionalSpineBones = 0x380; // Transform[]
        public const Int32 LegParts = 0x388; // List<SkinnedMeshRenderer>
        public const Int32 fadeToggles = 0x390; // List<WearableFadeToggle>
        public const Int32 fakeSpineBones = 0x398; // Transform[]
        public const Int32 extraLeanBack = 0x3A0; // float
        public const Int32 timeInArmsMode = 0x3A8; // float
    }
    public static class ModelState
    {
        public const Int32 waterLevel = 0x10; // float
        public const Int32 lookDir = 0x14; // Vector3
        public const Int32 flags = 0x20; // int
        public const Int32 poseType = 0x24; // int
        public const Int32 inheritedVelocity = 0x28; // Vector3
        public const Int32 ladderType = 0x34; // int
        public const Int32 guidePosition = 0x38; // Vector3
        public const Int32 guideRotation = 0x44; // Vector3
        public const Int32 guidePrefab = 0x50; // uint
        public const Int32 guideValid = 0x54; // bool
        public const Int32 guideVersion = 0x58; // int
        public const Int32 ShouldPool = 0x5C; // bool
        public const Int32 _disposed = 0x5D; // bool
    }
    public static class Item
    {
        public const Int32 _condition = 0x10; // float
        public const Int32 _maxCondition = 0x14; // float
        public const Int32 info = 0x18; // ItemDefinition
        public const Int32 uid = 0x20; // ItemId
        public const Int32 dirty = 0x28; // bool
        public const Int32 amount = 0x2C; // int
        public const Int32 position = 0x30; // int
        public const Int32 busyTime = 0x34; // float
        public const Int32 removeTime = 0x38; // float
        public const Int32 fuel = 0x3C; // float
        public const Int32 isServer = 0x40; // bool
        public const Int32 instanceData = 0x48; // Item.InstanceData
        public const Int32 skin = 0x50; // ulong
        public const Int32 name = 0x58; // string
        public const Int32 streamerName = 0x60; // string
        public const Int32 text = 0x68; // string
        public const Int32 ammoCount = 0x70; // Nullable<int>
        public const Int32 cookTimeLeft = 0x78; // float
        public const Int32 progressBar = 0x7C; // float
        public const Int32 flags = 0x88; // Item.Flag
        public const Int32 contents = 0x90; // ItemContainer
        public const Int32 parent = 0x98; // ItemContainer
        public const Int32 worldEnt = 0xA0; // EntityRef
        public const Int32 heldEntity = 0xB0; // EntityRef
    }
    public static class Model
    {
        public const Int32 collision = 0x20; // SphereCollider
        public const Int32 rootBone = 0x28; // Transform
        public const Int32 headBone = 0x30; // Transform
        public const Int32 eyeBone = 0x38; // Transform
        public const Int32 animator = 0x40; // Animator
        public const Int32 skeleton = 0x48; // Skeleton
        public const Int32 boneTransforms = 0x50; // Transform[]
        public const Int32 boneNames = 0x58; // string[]
        public const Int32 boneDict = 0x60; // BoneDictionary
        public const Int32 skin = 0x68; // int
        public const Int32 _lodGroup = 0x70; // LODGroup
    }
    public static class RecoilProperties
    {
        public const Int32 recoilYawMin = 0x18; // float
        public const Int32 recoilYawMax = 0x1C; // float
        public const Int32 recoilPitchMin = 0x20; // float
        public const Int32 recoilPitchMax = 0x24; // float
        public const Int32 timeToTakeMin = 0x28; // float
        public const Int32 timeToTakeMax = 0x2C; // float
        public const Int32 ADSScale = 0x30; // float
        public const Int32 movementPenalty = 0x34; // float
        public const Int32 clampPitch = 0x38; // float
        public const Int32 pitchCurve = 0x40; // AnimationCurve
        public const Int32 yawCurve = 0x48; // AnimationCurve
        public const Int32 useCurves = 0x50; // bool
        public const Int32 curvesAsScalar = 0x51; // bool
        public const Int32 shotsUntilMax = 0x54; // int
        public const Int32 maxRecoilRadius = 0x58; // float
        public const Int32 overrideAimconeWithCurve = 0x5C; // bool
        public const Int32 aimconeCurveScale = 0x60; // float
        public const Int32 aimconeCurve = 0x68; // AnimationCurve
        public const Int32 aimconeProbabilityCurve = 0x70; // AnimationCurve
        public const Int32 ammoAimconeScaleMultiProjectile = 0x78; // float
        public const Int32 ammoAimconeScaleSingleProjectile = 0x7C; // float
        public const Int32 newRecoilOverride = 0x80; // RecoilProperties
    }
    public static class BaseFishingRod
    {
        public const Int32 FishingBobberRef = 0x218; // GameObjectRef
        public const Int32 FishCatchDistance = 0x220; // float
        public const Int32 ReelLineRenderer = 0x228; // LineRenderer
        public const Int32 LineRendererWorldStartPos = 0x230; // Transform
        public const Int32 CurrentState = 0x238; // BaseFishingRod.CatchState
        public const Int32 currentFishState = 0x23C; // BaseFishingRod.FishState
        public const Int32 currentBobber = 0x240; // EntityRef<FishingBobber>
        public const Int32 ConditionLossOnSuccess = 0x250; // float
        public const Int32 ConditionLossOnFail = 0x254; // float
        public const Int32 GlobalStrainSpeedMultiplier = 0x258; // float
        public const Int32 MaxCastDistance = 0x25C; // float
        public const Int32 ForceFish = 0x260; // ItemModFishable
        public const Int32 BobberPreview = 0x268; // GameObjectRef
        public const Int32 onLineSoundDef = 0x270; // SoundDefinition
        public const Int32 strainSoundDef = 0x278; // SoundDefinition
        public const Int32 strainGainCurve = 0x280; // AnimationCurve
        public const Int32 tensionBreakSoundDef = 0x288; // SoundDefinition
        public const Int32 lineRendererPositionsArray = 0x290; // Vector3[]
        public const Int32 lineRendererResultArray = 0x298; // Vector3[]
        public const Int32 lineRendererSlack = 0x2A0; // float[]
        public const Int32 clientStrainAmountNormalised = 0x2A8; // float
        public const Int32 canCancel = 0x2AC; // TimeUntil
        public const Int32 rodViewModel = 0x2B0; // FishingRodViewmodel
        public const Int32 spawnedPreview = 0x2B8; // BobberPreview
        public const Int32 aimAnimationReady = 0x2C0; // bool
        public const Int32 onLineSound = 0x2C8; // Sound
        public const Int32 strainSound = 0x2D0; // Sound
        public const Int32 strainGainMod = 0x2D8; // SoundModulation.Modulator
        public const Int32 consumingBackMovement = 0x2E0; // TimeUntil
        public const Int32 reelInAnimTimer = 0x2E4; // TimeSince
    }
    public static class FishingBobber
    {
        public const Int32 centerOfMass = 0x290; // Transform
        public const Int32 myRigidBody = 0x298; // Rigidbody
        public const Int32 lineAttachPoint = 0x2A0; // Transform
        public const Int32 bobberRoot = 0x2A8; // Transform
        public const Int32 HorizontalMoveSpeed = 0x2B0; // float
        public const Int32 PullAwayMoveSpeed = 0x2B4; // float
        public const Int32 SidewaysInputForce = 0x2B8; // float
        public const Int32 ReelInMoveSpeed = 0x2BC; // float
        public const Int32 fishLerp = 0x2C0; // float
        public const Int32 lastPosition = 0x2C4; // Vector3
    }
    public static class OcclusionCulling
    {
        public const Int32 computeShader = 0x20; // ComputeShader
        public const Int32 usePixelShaderFallback = 0x28; // bool
        public const Int32 useAsyncReadAPI = 0x29; // bool
        public const Int32 camera = 0x30; // Camera
        public const Int32 static_staticSet = 0x58; // OcclusionCulling.BufferSet
        public const Int32 static_dynamicSet = 0x60; // OcclusionCulling.BufferSet
        public const Int32 static_gridSet = 0x68; // OcclusionCulling.BufferSet
        public const Int32 frustumPlanes = 0x38; // Vector4[]
        public const Int32 frustumPropNames = 0x40; // string[]
        public const Int32 matrixToFloatTemp = 0x48; // float[]
        public const Int32 fallbackMat = 0x50; // Material
        public const Int32 depthCopyMat = 0x58; // Material
        public const Int32 viewMatrix = 0x60; // Matrix4x4
        public const Int32 projMatrix = 0xA0; // Matrix4x4
        public const Int32 viewProjMatrix = 0xE0; // Matrix4x4
        public const Int32 prevViewProjMatrix = 0x120; // Matrix4x4
        public const Int32 invViewProjMatrix = 0x160; // Matrix4x4
        public const Int32 useNativePath = 0x1A0; // bool
        public const Int32 static_instance = 0x70; // OcclusionCulling
        public const Int32 static_Passthrough = 0x78; // bool
        public const Int32 static__enabled = 0x88; // bool
        public const Int32 static__safeMode = 0x89; // bool
        public const Int32 static__debugShow = 0x8C; // OcclusionCulling.DebugFilter
        public const Int32 debugSettings = 0x1A8; // OcclusionCulling.DebugSettings
        public const Int32 debugMipMat = 0x1B0; // Material
        public const Int32 downscaleMat = 0x1B8; // Material
        public const Int32 blitCopyMat = 0x1C0; // Material
        public const Int32 hiZLevelCount = 0x1C8; // int
        public const Int32 hiZWidth = 0x1CC; // int
        public const Int32 hiZHeight = 0x1D0; // int
        public const Int32 depthTexture = 0x1D8; // RenderTexture
        public const Int32 hiZTexture = 0x1E0; // RenderTexture
        public const Int32 hiZLevels = 0x1E8; // RenderTexture[]
    }
    public static class OcclusionCulling.DebugSettings
    {
        public const Int32 log = 0x10; // bool
        public const Int32 showAllVisible = 0x11; // bool
        public const Int32 showMipChain = 0x12; // bool
        public const Int32 showMain = 0x13; // bool
        public const Int32 showMainLod = 0x14; // int
        public const Int32 showFallback = 0x18; // bool
        public const Int32 showStats = 0x19; // bool
        public const Int32 showScreenBounds = 0x1A; // bool
        public const Int32 showMask = 0x1C; // OcclusionCulling.DebugMask
        public const Int32 layerFilter = 0x20; // LayerMask
    }
    public static class PlayerInput
    {
        public const Int32 state = 0x28; // InputState
        public const Int32 hadInputBuffer = 0x30; // bool
        public const Int32 bodyRotation = 0x34; // Quaternion
        public const Int32 bodyAngles = 0x44; // Vector3
        public const Int32 bodyAnglesOverride = 0x50; // Vector3
        public const Int32 clearBodyAnglesOverrideOnLerpComplete = 0x5C; // bool
        public const Int32 bodyAnglesOverrideLerpSpeed = 0x60; // float
        public const Int32 headRotation = 0x64; // Quaternion
        public const Int32 headAngles = 0x74; // Vector3
        public const Int32 recoilAngles = 0x80; // Vector3
        public const Int32 viewDelta = 0x8C; // Vector2
        public const Int32 headLerp = 0x94; // float
        public const Int32 mouseWheelUp = 0x98; // int
        public const Int32 mouseWheelDn = 0x9C; // int
        public const Int32 autorun = 0xA0; // bool
        public const Int32 toggleDuck = 0xA1; // bool
        public const Int32 toggleAds = 0xA2; // bool
        public const Int32 lastAdsEntity = 0xA8; // NetworkableId
        public const Int32 pendingMouseDelta = 0xB0; // Vector3
        public const Int32 offsetAngles = 0xBC; // Vector3
        public const Int32 ignoredButtons = 0xC8; // int
        public const Int32 hasKeyFocus = 0xCC; // bool
    }
    public static class ItemDefinition
    {
        public const Int32 itemid = 0x20; // int
        public const Int32 shortname = 0x28; // string
        public const Int32 displayName = 0x30; // Translate.Phrase
        public const Int32 displayDescription = 0x38; // Translate.Phrase
        public const Int32 iconSprite = 0x40; // Sprite
        public const Int32 category = 0x48; // ItemCategory
        public const Int32 selectionPanel = 0x4C; // ItemSelectionPanel
        public const Int32 maxDraggable = 0x50; // int
        public const Int32 itemType = 0x54; // ItemContainer.ContentsType
        public const Int32 amountType = 0x58; // ItemDefinition.AmountType
        public const Int32 occupySlots = 0x5C; // ItemSlot
        public const Int32 stackable = 0x60; // int
        public const Int32 volume = 0x64; // int
        public const Int32 quickDespawn = 0x68; // bool
        public const Int32 blockStealingInSafeZone = 0x69; // bool
        public const Int32 tutorialAllowance = 0x6C; // BasePlayer.TutorialItemAllowance
        public const Int32 rarity = 0x70; // Rarity
        public const Int32 despawnRarity = 0x74; // Rarity
        public const Int32 spawnAsBlueprint = 0x78; // bool
        public const Int32 inventoryGrabSound = 0x80; // SoundDefinition
        public const Int32 inventoryDropSound = 0x88; // SoundDefinition
        public const Int32 physImpactSoundDef = 0x90; // SoundDefinition
        public const Int32 condition = 0x98; // ItemDefinition.Condition
        public const Int32 hidden = 0xB0; // bool
        public const Int32 flags = 0xB4; // ItemDefinition.Flag
        public const Int32 hideSelectedPanel = 0xB8; // bool
        public const Int32 steamItem = 0xC0; // SteamInventoryItem
        public const Int32 steamDlc = 0xC8; // SteamDLCItem
        public const Int32 Parent = 0xD0; // ItemDefinition
        public const Int32 worldModelPrefab = 0xD8; // GameObjectRef
        public const Int32 treatAsComponentForRepairs = 0xE8; // bool
        public const Int32 AlignWorldModelOnDrop = 0xE9; // bool
        public const Int32 WorldModelDropOffset = 0xEC; // Vector3
        public const Int32 isRedirectOf = 0xF8; // ItemDefinition
        public const Int32 redirectVendingBehaviour = 0x100; // ItemDefinition.RedirectVendingBehaviour
        public const Int32 itemMods = 0x108; // ItemMod[]
        public const Int32 Traits = 0x110; // BaseEntity.TraitFlag
        public const Int32 _skins2 = 0x120; // IPlayerItemDefinition[]
        public const Int32 panel = 0x128; // GameObject
        public const Int32 ItemModWearable = 0x130; // ItemModWearable
        public const Int32 ItemModBurnable = 0x138; // ItemModBurnable
        public const Int32 ItemModCookable = 0x140; // ItemModCookable
        public const Int32 isHoldable = 0x148; // bool
        public const Int32 isUsable = 0x149; // bool
        public const Int32 CraftableWithSkin = 0x14A; // bool
        public const Int32 Children = 0x150; // ItemDefinition[]
    }
    public static class PlayerEyes
    {
        public const Int32 thirdPersonSleepingOffset = 0x28; // Vector3
        public const Int32 defaultLazyAim = 0x38; // LazyAimProperties
        public const Int32 viewOffset = 0x40; // Vector3
        public const Int32 bodyRotation = 0x4C; // Quaternion
        public const Int32 headAngles = 0x5C; // Vector3
        public const Int32 rotationLook = 0x68; // Quaternion
        public const Int32 postRotationLook = 0x78; // Quaternion
        public const Int32 postRotationLookAlpha = 0x88; // float
        public const Int32 IsAltLookingLegsThreshold = 0x8C; // bool
    }
    public static class Projectile
    {
        public const Int32 initialVelocity = 0x20; // Vector3
        public const Int32 drag = 0x2C; // float
        public const Int32 gravityModifier = 0x30; // float
        public const Int32 thickness = 0x34; // float
        public const Int32 initialDistance = 0x38; // float
        public const Int32 remainInWorld = 0x3C; // bool
        public const Int32 stickProbability = 0x40; // float
        public const Int32 breakProbability = 0x44; // float
        public const Int32 conditionLoss = 0x48; // float
        public const Int32 ricochetChance = 0x4C; // float
        public const Int32 penetrationPower = 0x50; // float
        public const Int32 waterIntegrityLoss = 0x54; // float
        public const Int32 damageProperties = 0x58; // DamageProperties
        public const Int32 damageDistances = 0x60; // MinMax
        public const Int32 damageMultipliers = 0x68; // MinMax
        public const Int32 damageTypes = 0x70; // List<DamageTypeEntry>
        public const Int32 rendererToScale = 0x78; // ScaleRenderer
        public const Int32 firstPersonRenderer = 0x80; // ScaleRenderer
        public const Int32 createDecals = 0x88; // bool
        public const Int32 doDefaultHitEffects = 0x89; // bool
        public const Int32 flybySound = 0x90; // SoundDefinition
        public const Int32 flybySoundDistance = 0x98; // float
        public const Int32 closeFlybySound = 0xA0; // SoundDefinition
        public const Int32 closeFlybyDistance = 0xA8; // float
        public const Int32 tumbleSpeed = 0xAC; // float
        public const Int32 tumbleAxis = 0xB0; // Vector3
        public const Int32 swimScale = 0xBC; // Vector3
        public const Int32 swimSpeed = 0xC8; // Vector3
        public const Int32 owner = 0xD8; // BasePlayer
        public const Int32 sourceWeaponPrefab = 0xE0; // AttackEntity
        public const Int32 sourceProjectilePrefab = 0xE8; // Projectile
        public const Int32 mod = 0xF0; // ItemModProjectile
        public const Int32 projectileID = 0xF8; // int
        public const Int32 seed = 0xFC; // int
        public const Int32 clientsideEffect = 0x100; // bool
        public const Int32 clientsideAttack = 0x101; // bool
        public const Int32 integrity = 0x104; // float
        public const Int32 maxDistance = 0x108; // float
        public const Int32 modifier = 0x10C; // Projectile.Modifier
        public const Int32 invisible = 0x11C; // bool
        public const Int32 noheadshots = 0x11D; // bool
        public const Int32 currentThickness = 0x120; // float
        public const Int32 currentVelocity = 0x124; // Vector3
        public const Int32 currentPosition = 0x130; // Vector3
        public const Int32 traveledDistance = 0x13C; // float
        public const Int32 traveledTime = 0x140; // float
        public const Int32 launchTime = 0x144; // float
        public const Int32 sentPosition = 0x148; // Vector3
        public const Int32 previousPosition = 0x154; // Vector3
        public const Int32 previousVelocity = 0x160; // Vector3
        public const Int32 previousTraveledTime = 0x16C; // float
        public const Int32 isUnderwater = 0x170; // bool
        public const Int32 isRicochet = 0x171; // bool
        public const Int32 isRetiring = 0x172; // bool
        public const Int32 flybyPlayed = 0x173; // bool
        public const Int32 wasFacingPlayer = 0x174; // bool
        public const Int32 flybyPlane = 0x178; // Plane
        public const Int32 flybyRay = 0x188; // Ray
        public const Int32 cleanupAction = 0x1A0; // Action
        public const Int32 hitTest = 0x1A8; // HitTest
        public const Int32 swimRandom = 0x1B0; // float
    }
    public static class ItemModProjectile
    {
        public const Int32 projectileObject = 0x20; // GameObjectRef
        public const Int32 mods = 0x28; // ItemModProjectileMod[]
        public const Int32 ammoType = 0x30; // AmmoTypes
        public const Int32 numProjectiles = 0x34; // int
        public const Int32 projectileSpread = 0x38; // float
        public const Int32 projectileVelocity = 0x3C; // float
        public const Int32 projectileVelocitySpread = 0x40; // float
        public const Int32 useCurve = 0x44; // bool
        public const Int32 spreadScalar = 0x48; // AnimationCurve
        public const Int32 attackEffectOverride = 0x50; // GameObjectRef
        public const Int32 barrelConditionLoss = 0x58; // float
        public const Int32 category = 0x60; // string
    }
} // namespace blazedumper
