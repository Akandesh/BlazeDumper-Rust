using System;
namespace blazedumper {
    public static class BaseEntity_TypeInfo
    {
    public const Int32 offset = 0x2EAC938;
    }
    public static class Facepunch_Input_TypeInfo
    {
    public const Int32 offset = 0x2EF8F20;
    }
    public static class MainCamera_TypeInfo
    {
    public const Int32 offset = 0x2F0A650;
    }
    public static class System_Collections_Generic_List_BaseGameMode_TypeInfo
    {
    public const Int32 offset = 0x2EE9858;
    }
    public static class BaseGameMode_TypeInfo
    {
    public const Int32 offset = 0x2EACBA8;
    }
    public static class BasePlayer
    {
        public const Int32 __menuOption_Climb = 0x240; // Option
        public const Int32 __menuOption_Drink = 0x298; // Option
        public const Int32 __menuOption_InviteToTeam = 0x2F0; // Option
        public const Int32 __menuOption_Menu_AssistPlayer = 0x348; // Option
        public const Int32 __menuOption_Menu_LootPlayer = 0x3A0; // Option
        public const Int32 __menuOption_Promote = 0x3F8; // Option
        public const Int32 __menuOption_SaltWater = 0x450; // Option
        public const Int32 playerModel = 0x4A8; // PlayerModel
        public const Int32 Frozen = 0x4B0; // bool
        public const Int32 voiceRecorder = 0x4B8; // PlayerVoiceRecorder
        public const Int32 voiceSpeaker = 0x4C0; // PlayerVoiceSpeaker
        public const Int32 input = 0x4C8; // PlayerInput
        public const Int32 movement = 0x4D0; // BaseMovement
        public const Int32 collision = 0x4D8; // BaseCollision
        public const Int32 _lookingAt = 0x4E0; // GameObject
        public const Int32 _lookingAtEntity = 0x4E8; // BaseEntity
        public const Int32 _lookingAtCollider = 0x4F0; // Collider
        public const Int32 lookingAtPoint = 0x4F8; // Vector3
        public const Int32 wakeTime = 0x504; // float
        public const Int32 needsClothesRebuild = 0x508; // bool
        public const Int32 wasSleeping = 0x509; // bool
        public const Int32 wokeUpBefore = 0x50A; // bool
        public const Int32 wasDead = 0x50B; // bool
        public const Int32 lastClothesHash = 0x50C; // uint
        public const Int32 lastOpenSoundPlay = 0x510; // TimeSince
        public const Int32 currentViewMode = 0x514; // BasePlayer.CameraMode
        public const Int32 selectedViewMode = 0x518; // BasePlayer.CameraMode
        public const Int32 lastRevivePoint = 0x51C; // Vector3
        public const Int32 lastReviveDirection = 0x528; // Vector3
        public const Int32 IsWearingDiveGoggles = 0x534; // bool
        public const Int32 GestureViewModel = 0x538; // ViewModel
        public const Int32 timeSinceUpdatedLookingAt = 0x540; // RealTimeSince
        public const Int32 nextTopologyTestTime = 0x544; // float
        public const Int32 usePressTime = 0x548; // float
        public const Int32 useHeldTime = 0x54C; // float
        public const Int32 lookingAtTest = 0x550; // HitTest
        public const Int32 cachedWaterDrinkingPoint = 0x558; // Vector3
        public const Int32 gestureList = 0x568; // GestureCollection
        public const Int32 gestureFinishedTime = 0x570; // TimeUntil
        public const Int32 blockHeldInputTimer = 0x574; // TimeSince
        public const Int32 currentGesture = 0x578; // GestureConfig
        public const Int32 disabledHeldEntity = 0x580; // HeldEntity
        public const Int32 nextGestureMenuOpenTime = 0x588; // float
        public const Int32 lastGestureCancel = 0x58C; // TimeSince
        public const Int32 client_lastHelloTime = 0x590; // float
        public const Int32 currentTeam = 0x598; // ulong
        public const Int32 clientTeam = 0x5A0; // PlayerTeam
        public const Int32 lastReceivedTeamTime = 0x5A8; // float
        public const Int32 lastPresenceTeamId = 0x5B0; // ulong
        public const Int32 lastPresenceTeamSize = 0x5B8; // int
        public const Int32 playerGroupKey = 0x5C0; // string
        public const Int32 playerGroupSizeKey = 0x5C8; // string
        public const Int32 clActiveItem = 0x5D0; // uint
        public const Int32 ClientCurrentMapNote = 0x5D8; // MapNote
        public const Int32 ClientCurrentDeathNote = 0x5E0; // MapNote
        public const Int32 missions = 0x5E8; // List<BaseMission.MissionInstance>
        public const Int32 _activeMission = 0x5F0; // int
        public const Int32 modelState = 0x5F8; // ModelState
        public const Int32 mounted = 0x600; // EntityRef
        public const Int32 nextSeatSwapTime = 0x610; // float
        public const Int32 PetEntity = 0x618; // BaseEntity
        public const Int32 lastPetCommandIssuedTime = 0x620; // float
        public const Int32 PetPrefabID = 0x624; // uint
        public const Int32 PetID = 0x628; // uint
        public const Int32 cachedBuildingPrivilegeTime = 0x62C; // float
        public const Int32 cachedBuildingPrivilege = 0x630; // BuildingPrivlidge
        public const Int32 maxProjectileID = 0x638; // int
        public const Int32 lastUpdateTime = 0x63C; // float
        public const Int32 cachedThreatLevel = 0x640; // float
        public const Int32 serverTickRate = 0x644; // int
        public const Int32 clientTickRate = 0x648; // int
        public const Int32 serverTickInterval = 0x64C; // float
        public const Int32 clientTickInterval = 0x650; // float
        public const Int32 lastSentTickTime = 0x654; // float
        public const Int32 lastTickStopwatch = 0x658; // Stopwatch
        public const Int32 lastSentTick = 0x660; // PlayerTick
        public const Int32 nextVisThink = 0x668; // float
        public const Int32 lastTimeSeen = 0x66C; // float
        public const Int32 debugPrevVisible = 0x670; // bool
        public const Int32 fallDamageEffect = 0x678; // GameObjectRef
        public const Int32 drownEffect = 0x680; // GameObjectRef
        public const Int32 playerFlags = 0x688; // BasePlayer.PlayerFlags
        public const Int32 eyes = 0x690; // PlayerEyes
        public const Int32 inventory = 0x698; // PlayerInventory
        public const Int32 blueprints = 0x6A0; // PlayerBlueprints
        public const Int32 metabolism = 0x6A8; // PlayerMetabolism
        public const Int32 modifiers = 0x6B0; // PlayerModifiers
        public const Int32 playerCollider = 0x6B8; // CapsuleCollider
        public const Int32 Belt = 0x6C0; // PlayerBelt
        public const Int32 playerRigidbody = 0x6C8; // Rigidbody
        public const Int32 userID = 0x6D0; // ulong
        public const Int32 UserIDString = 0x6D8; // string
        public const Int32 gamemodeteam = 0x6E0; // int
        public const Int32 reputation = 0x6E4; // int
        public const Int32 _displayName = 0x6E8; // string
        public const Int32 _lastSetName = 0x6F0; // string
        public const Int32 playerColliderStanding = 0x6F8; // BasePlayer.CapsuleColliderInfo
        public const Int32 playerColliderDucked = 0x70C; // BasePlayer.CapsuleColliderInfo
        public const Int32 playerColliderCrawling = 0x720; // BasePlayer.CapsuleColliderInfo
        public const Int32 playerColliderLyingDown = 0x734; // BasePlayer.CapsuleColliderInfo
        public const Int32 cachedProtection = 0x748; // ProtectionProperties
        public const Int32 lastHeadshotSoundTime = 0x750; // float
        public const Int32 nextColliderRefreshTime = 0x754; // float
        public const Int32 clothingBlocksAiming = 0x758; // bool
        public const Int32 clothingMoveSpeedReduction = 0x75C; // float
        public const Int32 clothingWaterSpeedBonus = 0x760; // float
        public const Int32 clothingAccuracyBonus = 0x764; // float
        public const Int32 equippingBlocked = 0x768; // bool
        public const Int32 eggVision = 0x76C; // float
        public const Int32 activeTelephone = 0x770; // PhoneController
        public const Int32 designingAIEntity = 0x778; // BaseEntity
    }
    public static class BaseEntity
    {
        public const Int32 ragdoll = 0x78; // Ragdoll
        public const Int32 positionLerp = 0x80; // PositionLerp
        public const Int32 menuOptions = 0x88; // List<Option>
        public const Int32 bounds = 0x90; // Bounds
        public const Int32 impactEffect = 0xA8; // GameObjectRef
        public const Int32 enableSaving = 0xB0; // bool
        public const Int32 syncPosition = 0xB1; // bool
        public const Int32 model = 0xB8; // Model
        public const Int32 flags = 0xC0; // BaseEntity.Flags
        public const Int32 parentBone = 0xC4; // uint
        public const Int32 skinID = 0xC8; // ulong
        public const Int32 _components = 0xD0; // EntityComponentBase[]
        public const Int32 HasBrain = 0xD8; // bool
        public const Int32 _name = 0xE0; // string
        public const Int32 OwnerID = 0xE8; // ulong
        public const Int32 broadcastProtocol = 0xF0; // uint
        public const Int32 links = 0xF8; // List<EntityLink>
        public const Int32 linkedToNeighbours = 0x100; // bool
        public const Int32 _pendingFileRequests = 0x108; // List<BaseEntity.PendingFileRequest>
        public const Int32 updateParentingAction = 0x110; // Action
        public const Int32 addedToParentEntity = 0x118; // BaseEntity
        public const Int32 itemSkin = 0x120; // ItemSkin
        public const Int32 entitySlots = 0x128; // EntityRef[]
        public const Int32 triggers = 0x130; // List<TriggerBase>
        public const Int32 isVisible = 0x138; // bool
        public const Int32 isAnimatorVisible = 0x139; // bool
        public const Int32 isShadowVisible = 0x13A; // bool
        public const Int32 localOccludee = 0x140; // OccludeeSphere
        public const Int32 Weight = 0x160; // float
    }
    public static class BaseCombatEntity
    {
        public const Int32 __menuOption_Menu_Pickup = 0x168; // Option
        public const Int32 skeletonProperties = 0x1C0; // SkeletonProperties
        public const Int32 baseProtection = 0x1C8; // ProtectionProperties
        public const Int32 startHealth = 0x1D0; // float
        public const Int32 pickup = 0x1D8; // BaseCombatEntity.Pickup
        public const Int32 repair = 0x1F8; // BaseCombatEntity.Repair
        public const Int32 ShowHealthInfo = 0x220; // bool
        public const Int32 lifestate = 0x224; // BaseCombatEntity.LifeState
        public const Int32 sendsHitNotification = 0x228; // bool
        public const Int32 sendsMeleeHitNotification = 0x229; // bool
        public const Int32 markAttackerHostile = 0x22A; // bool
        public const Int32 _health = 0x22C; // float
        public const Int32 _maxHealth = 0x230; // float
        public const Int32 faction = 0x234; // BaseCombatEntity.Faction
        public const Int32 deathTime = 0x238; // float
        public const Int32 lastNotifyFrame = 0x23C; // int
    }
    public static class BuildingPrivlidge
    {
        public const Int32 __menuOption_Menu_MaxAuth = 0x3D0; // Option
        public const Int32 __menuOption_Menu_RotateVM = 0x428; // Option
        public const Int32 __menuOption_MenuAuthorize = 0x480; // Option
        public const Int32 __menuOption_MenuClearList = 0x4D8; // Option
        public const Int32 __menuOption_MenuDeauthorize = 0x530; // Option
        public const Int32 authorizedPlayers = 0x588; // List<PlayerNameID>
        public const Int32 allowedConstructionItems = 0x590; // List<ItemDefinition>
        public const Int32 cachedProtectedMinutes = 0x598; // float
        public const Int32 cachedUpkeepPeriodMinutes = 0x59C; // float
        public const Int32 cachedUpkeepCostFraction = 0x5A0; // float
    }
    public static class BaseProjectile
    {
        public const Int32 NoiseRadius = 0x280; // float
        public const Int32 damageScale = 0x284; // float
        public const Int32 distanceScale = 0x288; // float
        public const Int32 projectileVelocityScale = 0x28C; // float
        public const Int32 automatic = 0x290; // bool
        public const Int32 usableByTurret = 0x291; // bool
        public const Int32 turretDamageScale = 0x294; // float
        public const Int32 attackFX = 0x298; // GameObjectRef
        public const Int32 silencedAttack = 0x2A0; // GameObjectRef
        public const Int32 muzzleBrakeAttack = 0x2A8; // GameObjectRef
        public const Int32 MuzzlePoint = 0x2B0; // Transform
        public const Int32 reloadTime = 0x2B8; // float
        public const Int32 canUnloadAmmo = 0x2BC; // bool
        public const Int32 primaryMagazine = 0x2C0; // BaseProjectile.Magazine
        public const Int32 fractionalReload = 0x2C8; // bool
        public const Int32 reloadStartDuration = 0x2CC; // float
        public const Int32 reloadFractionDuration = 0x2D0; // float
        public const Int32 reloadEndDuration = 0x2D4; // float
        public const Int32 aimSway = 0x2D8; // float
        public const Int32 aimSwaySpeed = 0x2DC; // float
        public const Int32 recoil = 0x2E0; // RecoilProperties
        public const Int32 aimconeCurve = 0x2E8; // AnimationCurve
        public const Int32 aimCone = 0x2F0; // float
        public const Int32 hipAimCone = 0x2F4; // float
        public const Int32 aimconePenaltyPerShot = 0x2F8; // float
        public const Int32 aimConePenaltyMax = 0x2FC; // float
        public const Int32 aimconePenaltyRecoverTime = 0x300; // float
        public const Int32 aimconePenaltyRecoverDelay = 0x304; // float
        public const Int32 stancePenaltyScale = 0x308; // float
        public const Int32 hasADS = 0x30C; // bool
        public const Int32 noAimingWhileCycling = 0x30D; // bool
        public const Int32 manualCycle = 0x30E; // bool
        public const Int32 needsCycle = 0x30F; // bool
        public const Int32 isCycling = 0x310; // bool
        public const Int32 aiming = 0x311; // bool
        public const Int32 useEmptyAmmoState = 0x312; // bool
        public const Int32 isBurstWeapon = 0x313; // bool
        public const Int32 canChangeFireModes = 0x314; // bool
        public const Int32 defaultOn = 0x315; // bool
        public const Int32 internalBurstRecoilScale = 0x318; // float
        public const Int32 internalBurstFireRateScale = 0x31C; // float
        public const Int32 internalBurstAimConeScale = 0x320; // float
        public const Int32 Toast_BurstDisabled = 0x328; // Translate.Phrase
        public const Int32 Toast_BurstEnabled = 0x330; // Translate.Phrase
        public const Int32 resetDuration = 0x338; // float
        public const Int32 numShotsFired = 0x33C; // int
        public const Int32 nextReloadTime = 0x340; // float
        public const Int32 startReloadTime = 0x344; // float
        public const Int32 stancePenalty = 0x348; // float
        public const Int32 aimconePenalty = 0x34C; // float
        public const Int32 cachedModHash = 0x350; // uint
        public const Int32 sightAimConeScale = 0x354; // float
        public const Int32 sightAimConeOffset = 0x358; // float
        public const Int32 hipAimConeScale = 0x35C; // float
        public const Int32 hipAimConeOffset = 0x360; // float
        public const Int32 isReloading = 0x364; // bool
        public const Int32 swaySampleTime = 0x368; // float
        public const Int32 lastShotTime = 0x36C; // float
        public const Int32 reloadPressTime = 0x370; // float
        public const Int32 ammoTypePreReload = 0x378; // ItemDefinition
        public const Int32 fractionalReloadDesiredCount = 0x380; // int
        public const Int32 fractionalReloadNumAdded = 0x384; // int
        public const Int32 currentBurst = 0x388; // int
        public const Int32 triggerReady = 0x38C; // bool
        public const Int32 nextHeightCheckTime = 0x390; // float
        public const Int32 cachedUnderground = 0x394; // bool
        public const Int32 createdProjectiles = 0x398; // List<Projectile>
    }
    public static class Magazine
    {
        public const Int32 definition = 0x10; // BaseProjectile.Magazine.Definition
        public const Int32 capacity = 0x18; // int
        public const Int32 contents = 0x1C; // int
        public const Int32 ammoType = 0x20; // ItemDefinition
    }
    public static class PlayerInventory
    {
        public const Int32 containerMain = 0x20; // ItemContainer
        public const Int32 containerBelt = 0x28; // ItemContainer
        public const Int32 containerWear = 0x30; // ItemContainer
        public const Int32 crafting = 0x38; // ItemCrafter
        public const Int32 loot = 0x40; // PlayerLoot
    }
    public static class ItemContainer
    {
        public const Int32 flags = 0x10; // ItemContainer.Flag
        public const Int32 allowedContents = 0x14; // ItemContainer.ContentsType
        public const Int32 onlyAllowedItems = 0x18; // ItemDefinition[]
        public const Int32 availableSlots = 0x20; // List<ItemSlot>
        public const Int32 capacity = 0x28; // int
        public const Int32 uid = 0x2C; // uint
        public const Int32 dirty = 0x30; // bool
        public const Int32 itemList = 0x38; // List<Item>
        public const Int32 temperature = 0x40; // float
        public const Int32 parent = 0x48; // Item
        public const Int32 playerOwner = 0x50; // BasePlayer
        public const Int32 entityOwner = 0x58; // BaseEntity
        public const Int32 isServer = 0x60; // bool
        public const Int32 maxStackSize = 0x64; // int
    }
    public static class PlayerModel
    {
        public const Int32 collision = 0x18; // BoxCollider
        public const Int32 censorshipCube = 0x20; // GameObject
        public const Int32 censorshipCubeBreasts = 0x28; // GameObject
        public const Int32 jawBone = 0x30; // GameObject
        public const Int32 neckBone = 0x38; // GameObject
        public const Int32 headBone = 0x40; // GameObject
        public const Int32 eyeController = 0x48; // EyeController
        public const Int32 blinkController = 0x50; // EyeBlink
        public const Int32 SpineBones = 0x58; // Transform[]
        public const Int32 leftFootBone = 0x60; // Transform
        public const Int32 rightFootBone = 0x68; // Transform
        public const Int32 leftHandPropBone = 0x70; // Transform
        public const Int32 rightHandPropBone = 0x78; // Transform
        public const Int32 rightHandTarget = 0x80; // Vector3
        public const Int32 leftHandTargetPosition = 0x8C; // Vector3
        public const Int32 leftHandTargetRotation = 0x98; // Quaternion
        public const Int32 rightHandTargetPosition = 0xA8; // Vector3
        public const Int32 rightHandTargetRotation = 0xB4; // Quaternion
        public const Int32 steeringTargetDegrees = 0xC4; // float
        public const Int32 rightFootTargetPosition = 0xC8; // Vector3
        public const Int32 rightFootTargetRotation = 0xD4; // Quaternion
        public const Int32 leftFootTargetPosition = 0xE4; // Vector3
        public const Int32 leftFootTargetRotation = 0xF0; // Quaternion
        public const Int32 CinematicAnimationController = 0x100; // RuntimeAnimatorController
        public const Int32 DefaultAvatar = 0x108; // Avatar
        public const Int32 CinematicAvatar = 0x110; // Avatar
        public const Int32 DefaultHoldType = 0x118; // RuntimeAnimatorController
        public const Int32 SleepGesture = 0x120; // RuntimeAnimatorController
        public const Int32 CrawlToIncapacitatedGesture = 0x128; // RuntimeAnimatorController
        public const Int32 StandToIncapacitatedGesture = 0x130; // RuntimeAnimatorController
        public const Int32 CurrentGesture = 0x138; // RuntimeAnimatorController
        public const Int32 MaleSkin = 0x140; // SkinSetCollection
        public const Int32 FemaleSkin = 0x148; // SkinSetCollection
        public const Int32 subsurfaceProfile = 0x150; // SubsurfaceProfile
        public const Int32 voiceVolume = 0x158; // float
        public const Int32 skinColor = 0x15C; // float
        public const Int32 skinNumber = 0x160; // float
        public const Int32 meshNumber = 0x164; // float
        public const Int32 hairNumber = 0x168; // float
        public const Int32 skinType = 0x16C; // int
        public const Int32 movementSounds = 0x170; // MovementSounds
        public const Int32 showSash = 0x178; // bool
        public const Int32 tempPoseType = 0x17C; // int
        public const Int32 underwearSkin = 0x180; // uint
        public const Int32 overrideSkinSeed = 0x188; // ulong
        public const Int32 AimAngles = 0x190; // Quaternion
        public const Int32 LookAngles = 0x1A0; // Quaternion
        public const Int32 modelState = 0x1B0; // ModelState
        public const Int32 position = 0x1B8; // Vector3
        public const Int32 velocity = 0x1C4; // Vector3
        public const Int32 speedOverride = 0x1D0; // Vector3
        public const Int32 newVelocity = 0x1DC; // Vector3
        public const Int32 rotation = 0x1E8; // Quaternion
        public const Int32 mountedRotation = 0x1F8; // Quaternion
        public const Int32 smoothLeftFootIK = 0x208; // Vector3
        public const Int32 smoothRightFootIK = 0x214; // Vector3
        public const Int32 drawShadowOnly = 0x220; // bool
        public const Int32 isIncapacitated = 0x221; // bool
        public const Int32 flinchLocation = 0x224; // uint
        public const Int32 visible = 0x228; // bool
        public const Int32 nameTag = 0x230; // PlayerNameTag
        public const Int32 animatorNeedsWarmup = 0x238; // bool
        public const Int32 isLocalPlayer = 0x239; // bool
        public const Int32 aimSoundDef = 0x240; // SoundDefinition
        public const Int32 aimEndSoundDef = 0x248; // SoundDefinition
        public const Int32 InGesture = 0x250; // bool
        public const Int32 CurrentGestureConfig = 0x258; // GestureConfig
        public const Int32 InCinematic = 0x260; // bool
        public const Int32 defaultAnimatorController = 0x268; // RuntimeAnimatorController
        public const Int32 _multiMesh = 0x270; // SkinnedMultiMesh
        public const Int32 _animator = 0x278; // Animator
        public const Int32 _lodGroup = 0x280; // LODGroup
        public const Int32 _currentGesture = 0x288; // RuntimeAnimatorController
        public const Int32 holdTypeLock = 0x290; // float
        public const Int32 hasHeldEntity = 0x294; // bool
        public const Int32 wasMountedRightAim = 0x295; // bool
        public const Int32 cachedMask = 0x298; // int
        public const Int32 cachedConstructionMask = 0x29C; // int
        public const Int32 WorkshopHeldEntity = 0x2A0; // HeldEntity
        public const Int32 wasCrawling = 0x2A8; // bool
        public const Int32 mountedSpineLookWeight = 0x2AC; // float
        public const Int32 mountedAnimSpeed = 0x2B0; // float
        public const Int32 preserveBones = 0x2B4; // bool
        public const Int32 blendShapeControllers = 0x2C0; // List<BlendShapeController>
        public const Int32 IsNpc = 0x2C8; // bool
        public const Int32 timeSinceReactionStart = 0x2CC; // TimeSince
        public const Int32 timeSinceLeftFootTest = 0x2D0; // TimeSince
        public const Int32 cachedLeftFootPos = 0x2D4; // Vector3
        public const Int32 cachedLeftFootNormal = 0x2E0; // Vector3
        public const Int32 timeSinceRightFootTest = 0x2EC; // TimeSince
        public const Int32 cachedRightFootPos = 0x2F0; // Vector3
        public const Int32 cachedRightFootNormal = 0x2FC; // Vector3
        public const Int32 _smoothAimWeight = 0x308; // float
        public const Int32 _smoothVelocity = 0x30C; // float
        public const Int32 _smoothlookAngle = 0x310; // Vector3
        public const Int32 allowMountedHeadLook = 0x31C; // bool
        public const Int32 smoothLookDir = 0x320; // Vector3
        public const Int32 lastSafeLookDir = 0x32C; // Vector3
        public const Int32 Shoulders = 0x338; // Transform[]
        public const Int32 AdditionalSpineBones = 0x340; // Transform[]
        public const Int32 LegParts = 0x348; // List<SkinnedMeshRenderer>
        public const Int32 fakeSpineBones = 0x350; // Transform[]
        public const Int32 extraLeanBack = 0x358; // float
        public const Int32 timeInArmsMode = 0x360; // float
    }
    public static class ModelState
    {
        public const Int32 waterLevel = 0x10; // float
        public const Int32 lookDir = 0x14; // Vector3
        public const Int32 flags = 0x20; // int
        public const Int32 poseType = 0x24; // int
        public const Int32 inheritedVelocity = 0x28; // Vector3
        public const Int32 ShouldPool = 0x34; // bool
        public const Int32 _disposed = 0x35; // bool
    }
    public static class Item
    {
        public const Int32 _condition = 0x10; // float
        public const Int32 _maxCondition = 0x14; // float
        public const Int32 info = 0x18; // ItemDefinition
        public const Int32 uid = 0x20; // uint
        public const Int32 dirty = 0x24; // bool
        public const Int32 amount = 0x28; // int
        public const Int32 position = 0x2C; // int
        public const Int32 busyTime = 0x30; // float
        public const Int32 removeTime = 0x34; // float
        public const Int32 fuel = 0x38; // float
        public const Int32 isServer = 0x3C; // bool
        public const Int32 instanceData = 0x40; // Item.InstanceData
        public const Int32 skin = 0x48; // ulong
        public const Int32 name = 0x50; // string
        public const Int32 text = 0x58; // string
        public const Int32 cookTimeLeft = 0x60; // float
        public const Int32 progressBar = 0x64; // float
        public const Int32 flags = 0x70; // Item.Flag
        public const Int32 contents = 0x78; // ItemContainer
        public const Int32 parent = 0x80; // ItemContainer
        public const Int32 worldEnt = 0x88; // EntityRef
        public const Int32 heldEntity = 0x98; // EntityRef
    }
    public static class Model
    {
        public const Int32 collision = 0x18; // SphereCollider
        public const Int32 rootBone = 0x20; // Transform
        public const Int32 headBone = 0x28; // Transform
        public const Int32 eyeBone = 0x30; // Transform
        public const Int32 animator = 0x38; // Animator
        public const Int32 skeleton = 0x40; // Skeleton
        public const Int32 boneTransforms = 0x48; // Transform[]
        public const Int32 boneNames = 0x50; // string[]
        public const Int32 boneDict = 0x58; // BoneDictionary
        public const Int32 skin = 0x60; // int
        public const Int32 _lodGroup = 0x68; // LODGroup
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
        public const Int32 newRecoilOverride = 0x78; // RecoilProperties
    }
    public static class BaseFishingRod
    {
        public const Int32 FishingBobberRef = 0x1F8; // GameObjectRef
        public const Int32 FishCatchDistance = 0x200; // float
        public const Int32 ReelLineRenderer = 0x208; // LineRenderer
        public const Int32 LineRendererWorldStartPos = 0x210; // Transform
        public const Int32 CurrentState = 0x218; // BaseFishingRod.CatchState
        public const Int32 currentFishState = 0x21C; // BaseFishingRod.FishState
        public const Int32 currentBobber = 0x220; // EntityRef<FishingBobber>
        public const Int32 ConditionLossOnSuccess = 0x230; // float
        public const Int32 ConditionLossOnFail = 0x234; // float
        public const Int32 GlobalStrainSpeedMultiplier = 0x238; // float
        public const Int32 MaxCastDistance = 0x23C; // float
        public const Int32 ForceFish = 0x240; // ItemModFishable
        public const Int32 BobberPreview = 0x248; // GameObjectRef
        public const Int32 onLineSoundDef = 0x250; // SoundDefinition
        public const Int32 strainSoundDef = 0x258; // SoundDefinition
        public const Int32 strainGainCurve = 0x260; // AnimationCurve
        public const Int32 tensionBreakSoundDef = 0x268; // SoundDefinition
        public const Int32 lineRendererPositionsArray = 0x270; // Vector3[]
        public const Int32 lineRendererResultArray = 0x278; // Vector3[]
        public const Int32 lineRendererSlack = 0x280; // float[]
        public const Int32 clientStrainAmountNormalised = 0x288; // float
        public const Int32 canCancel = 0x28C; // TimeUntil
        public const Int32 rodViewModel = 0x290; // FishingRodViewmodel
        public const Int32 spawnedPreview = 0x298; // BobberPreview
        public const Int32 aimAnimationReady = 0x2A0; // bool
        public const Int32 onLineSound = 0x2A8; // Sound
        public const Int32 strainSound = 0x2B0; // Sound
        public const Int32 strainGainMod = 0x2B8; // SoundModulation.Modulator
        public const Int32 consumingBackMovement = 0x2C0; // TimeUntil
        public const Int32 reelInAnimTimer = 0x2C4; // TimeSince
    }
    public static class FishingBobber
    {
        public const Int32 centerOfMass = 0x240; // Transform
        public const Int32 myRigidBody = 0x248; // Rigidbody
        public const Int32 lineAttachPoint = 0x250; // Transform
        public const Int32 bobberRoot = 0x258; // Transform
        public const Int32 HorizontalMoveSpeed = 0x260; // float
        public const Int32 PullAwayMoveSpeed = 0x264; // float
        public const Int32 SidewaysInputForce = 0x268; // float
        public const Int32 ReelInMoveSpeed = 0x26C; // float
        public const Int32 fishLerp = 0x270; // float
        public const Int32 lastPosition = 0x274; // Vector3
    }
} // namespace blazedumper
