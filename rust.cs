using System;
namespace blazedumper {
    public static class BaseEntity_TypeInfo
    {
    public const Int32 offset = 0x31D20C8;
    }
    public static class MainCamera_TypeInfo
    {
    public const Int32 offset = 0x31D3BF0;
    }
    public static class Facepunch.Input_TypeInfo
    {
    public const Int32 offset = 0x31E41B8;
    }
    public static class BasePlayer
    {
        public const Int32 __menuOption_Climb = 0x238; // Option
        public const Int32 __menuOption_Drink = 0x290; // Option
        public const Int32 __menuOption_InviteToTeam = 0x2E8; // Option
        public const Int32 __menuOption_Menu_AssistPlayer = 0x340; // Option
        public const Int32 __menuOption_Menu_LootPlayer = 0x398; // Option
        public const Int32 __menuOption_Promote = 0x3F0; // Option
        public const Int32 __menuOption_SaltWater = 0x448; // Option
        public const Int32 currentViewMode = 0x4A0; // BasePlayer.CameraMode
        public const Int32 selectedViewMode = 0x4A4; // BasePlayer.CameraMode
        public const Int32 lastRevivePoint = 0x4A8; // Vector3
        public const Int32 lastReviveDirection = 0x4B4; // Vector3
        public const Int32 playerModel = 0x4C0; // PlayerModel
        public const Int32 Frozen = 0x4C8; // bool
        public const Int32 voiceRecorder = 0x4D0; // PlayerVoiceRecorder
        public const Int32 voiceSpeaker = 0x4D8; // PlayerVoiceSpeaker
        public const Int32 input = 0x4E0; // PlayerInput
        public const Int32 movement = 0x4E8; // BaseMovement
        public const Int32 collision = 0x4F0; // BaseCollision
        public const Int32 _lookingAt = 0x4F8; // GameObject
        public const Int32 _lookingAtEntity = 0x500; // BaseEntity
        public const Int32 _lookingAtCollider = 0x508; // Collider
        public const Int32 lookingAtPoint = 0x510; // Vector3
        public const Int32 wakeTime = 0x51C; // float
        public const Int32 needsClothesRebuild = 0x520; // bool
        public const Int32 wasSleeping = 0x521; // bool
        public const Int32 wokeUpBefore = 0x522; // bool
        public const Int32 wasDead = 0x523; // bool
        public const Int32 lastClothesHash = 0x524; // uint
        public const Int32 IsWearingDiveGoggles = 0x528; // bool
        public const Int32 GestureViewModel = 0x530; // ViewModel
        public const Int32 timeSinceUpdatedLookingAt = 0x538; // RealTimeSince
        public const Int32 nextTopologyTestTime = 0x53C; // float
        public const Int32 usePressTime = 0x540; // float
        public const Int32 useHeldTime = 0x544; // float
        public const Int32 lookingAtTest = 0x548; // HitTest
        public const Int32 cachedWaterDrinkingPoint = 0x550; // Vector3
        public const Int32 gestureList = 0x560; // GestureCollection
        public const Int32 gestureFinishedTime = 0x568; // TimeUntil
        public const Int32 blockHeldInputTimer = 0x56C; // TimeSince
        public const Int32 currentGesture = 0x570; // GestureConfig
        public const Int32 disabledHeldEntity = 0x578; // HeldEntity
        public const Int32 nextGestureMenuOpenTime = 0x580; // float
        public const Int32 lastGestureCancel = 0x584; // TimeSince
        public const Int32 client_lastHelloTime = 0x588; // float
        public const Int32 currentTeam = 0x590; // ulong
        public const Int32 clientTeam = 0x598; // PlayerTeam
        public const Int32 lastReceivedTeamTime = 0x5A0; // float
        public const Int32 lastPresenceTeamId = 0x5A8; // ulong
        public const Int32 lastPresenceTeamSize = 0x5B0; // int
        public const Int32 playerGroupKey = 0x5B8; // string
        public const Int32 playerGroupSizeKey = 0x5C0; // string
        public const Int32 clActiveItem = 0x5C8; // uint
        public const Int32 ClientCurrentMapNote = 0x5D0; // MapNote
        public const Int32 ClientCurrentDeathNote = 0x5D8; // MapNote
        public const Int32 missions = 0x5E0; // List<BaseMission.MissionInstance>
        public const Int32 _activeMission = 0x5E8; // int
        public const Int32 modelState = 0x5F0; // ModelState
        public const Int32 mounted = 0x5F8; // EntityRef
        public const Int32 nextSeatSwapTime = 0x608; // float
        public const Int32 PetEntity = 0x610; // BaseEntity
        public const Int32 lastPetCommandIssuedTime = 0x618; // float
        public const Int32 PetPrefabID = 0x61C; // uint
        public const Int32 PetID = 0x620; // uint
        public const Int32 cachedBuildingPrivilegeTime = 0x624; // float
        public const Int32 cachedBuildingPrivilege = 0x628; // BuildingPrivlidge
        public const Int32 maxProjectileID = 0x630; // int
        public const Int32 lastUpdateTime = 0x634; // float
        public const Int32 cachedThreatLevel = 0x638; // float
        public const Int32 serverTickRate = 0x63C; // int
        public const Int32 clientTickRate = 0x640; // int
        public const Int32 serverTickInterval = 0x644; // float
        public const Int32 clientTickInterval = 0x648; // float
        public const Int32 lastSentTickTime = 0x64C; // float
        public const Int32 lastSentTick = 0x650; // PlayerTick
        public const Int32 nextVisThink = 0x658; // float
        public const Int32 lastTimeSeen = 0x65C; // float
        public const Int32 debugPrevVisible = 0x660; // bool
        public const Int32 fallDamageEffect = 0x668; // GameObjectRef
        public const Int32 drownEffect = 0x670; // GameObjectRef
        public const Int32 playerFlags = 0x678; // BasePlayer.PlayerFlags
        public const Int32 eyes = 0x680; // PlayerEyes
        public const Int32 inventory = 0x688; // PlayerInventory
        public const Int32 blueprints = 0x690; // PlayerBlueprints
        public const Int32 metabolism = 0x698; // PlayerMetabolism
        public const Int32 modifiers = 0x6A0; // PlayerModifiers
        public const Int32 playerCollider = 0x6A8; // CapsuleCollider
        public const Int32 Belt = 0x6B0; // PlayerBelt
        public const Int32 playerRigidbody = 0x6B8; // Rigidbody
        public const Int32 userID = 0x6C0; // ulong
        public const Int32 UserIDString = 0x6C8; // string
        public const Int32 gamemodeteam = 0x6D0; // int
        public const Int32 reputation = 0x6D4; // int
        public const Int32 _displayName = 0x6D8; // string
        public const Int32 _lastSetName = 0x6E0; // string
        public const Int32 playerColliderStanding = 0x6E8; // BasePlayer.CapsuleColliderInfo
        public const Int32 playerColliderDucked = 0x6FC; // BasePlayer.CapsuleColliderInfo
        public const Int32 playerColliderCrawling = 0x710; // BasePlayer.CapsuleColliderInfo
        public const Int32 playerColliderLyingDown = 0x724; // BasePlayer.CapsuleColliderInfo
        public const Int32 cachedProtection = 0x738; // ProtectionProperties
        public const Int32 lastHeadshotSoundTime = 0x740; // float
        public const Int32 nextColliderRefreshTime = 0x744; // float
        public const Int32 clothingBlocksAiming = 0x748; // bool
        public const Int32 clothingMoveSpeedReduction = 0x74C; // float
        public const Int32 clothingWaterSpeedBonus = 0x750; // float
        public const Int32 clothingAccuracyBonus = 0x754; // float
        public const Int32 equippingBlocked = 0x758; // bool
        public const Int32 eggVision = 0x75C; // float
        public const Int32 activeTelephone = 0x760; // PhoneController
        public const Int32 designingAIEntity = 0x768; // BaseEntity
    }
    public static class BaseEntity
    {
        public const Int32 ragdoll = 0x70; // Ragdoll
        public const Int32 positionLerp = 0x78; // PositionLerp
        public const Int32 menuOptions = 0x80; // List<Option>
        public const Int32 broadcastProtocol = 0x88; // uint
        public const Int32 links = 0x90; // List<EntityLink>
        public const Int32 linkedToNeighbours = 0x98; // bool
        public const Int32 _pendingFileRequests = 0xA0; // List<BaseEntity.ServerFileRequest>
        public const Int32 updateParentingAction = 0xA8; // Action
        public const Int32 addedToParentEntity = 0xB0; // BaseEntity
        public const Int32 itemSkin = 0xB8; // ItemSkin
        public const Int32 entitySlots = 0xC0; // EntityRef[]
        public const Int32 triggers = 0xC8; // List<TriggerBase>
        public const Int32 isVisible = 0xD0; // bool
        public const Int32 isAnimatorVisible = 0xD1; // bool
        public const Int32 isShadowVisible = 0xD2; // bool
        public const Int32 localOccludee = 0xD8; // OccludeeSphere
        public const Int32 Weight = 0xF8; // float
        public const Int32 bounds = 0xFC; // Bounds
        public const Int32 impactEffect = 0x118; // GameObjectRef
        public const Int32 enableSaving = 0x120; // bool
        public const Int32 syncPosition = 0x121; // bool
        public const Int32 model = 0x128; // Model
        public const Int32 flags = 0x130; // BaseEntity.Flags
        public const Int32 parentBone = 0x134; // uint
        public const Int32 skinID = 0x138; // ulong
        public const Int32 _components = 0x140; // EntityComponentBase[]
        public const Int32 HasBrain = 0x148; // bool
        public const Int32 _name = 0x150; // string
        public const Int32 OwnerID = 0x158; // ulong
    }
    public static class BaseCombatEntity
    {
        public const Int32 __menuOption_Menu_Pickup = 0x160; // Option
        public const Int32 skeletonProperties = 0x1B8; // SkeletonProperties
        public const Int32 baseProtection = 0x1C0; // ProtectionProperties
        public const Int32 startHealth = 0x1C8; // float
        public const Int32 pickup = 0x1D0; // BaseCombatEntity.Pickup
        public const Int32 repair = 0x1F0; // BaseCombatEntity.Repair
        public const Int32 ShowHealthInfo = 0x218; // bool
        public const Int32 lifestate = 0x21C; // BaseCombatEntity.LifeState
        public const Int32 sendsHitNotification = 0x220; // bool
        public const Int32 sendsMeleeHitNotification = 0x221; // bool
        public const Int32 markAttackerHostile = 0x222; // bool
        public const Int32 _health = 0x224; // float
        public const Int32 _maxHealth = 0x228; // float
        public const Int32 faction = 0x22C; // BaseCombatEntity.Faction
        public const Int32 deathTime = 0x230; // float
        public const Int32 lastNotifyFrame = 0x234; // int
    }
    public static class BuildingPrivlidge
    {
        public const Int32 __menuOption_Menu_MaxAuth = 0x3C8; // Option
        public const Int32 __menuOption_Menu_RotateVM = 0x420; // Option
        public const Int32 __menuOption_MenuAuthorize = 0x478; // Option
        public const Int32 __menuOption_MenuClearList = 0x4D0; // Option
        public const Int32 __menuOption_MenuDeauthorize = 0x528; // Option
        public const Int32 cachedProtectedMinutes = 0x580; // float
        public const Int32 cachedUpkeepPeriodMinutes = 0x584; // float
        public const Int32 cachedUpkeepCostFraction = 0x588; // float
        public const Int32 authorizedPlayers = 0x590; // List<PlayerNameID>
        public const Int32 allowedConstructionItems = 0x598; // List<ItemDefinition>
    }
    public static class BaseProjectile
    {
        public const Int32 NoiseRadius = 0x278; // float
        public const Int32 damageScale = 0x27C; // float
        public const Int32 distanceScale = 0x280; // float
        public const Int32 projectileVelocityScale = 0x284; // float
        public const Int32 automatic = 0x288; // bool
        public const Int32 usableByTurret = 0x289; // bool
        public const Int32 turretDamageScale = 0x28C; // float
        public const Int32 attackFX = 0x290; // GameObjectRef
        public const Int32 silencedAttack = 0x298; // GameObjectRef
        public const Int32 muzzleBrakeAttack = 0x2A0; // GameObjectRef
        public const Int32 MuzzlePoint = 0x2A8; // Transform
        public const Int32 reloadTime = 0x2B0; // float
        public const Int32 canUnloadAmmo = 0x2B4; // bool
        public const Int32 primaryMagazine = 0x2B8; // BaseProjectile.Magazine
        public const Int32 fractionalReload = 0x2C0; // bool
        public const Int32 reloadStartDuration = 0x2C4; // float
        public const Int32 reloadFractionDuration = 0x2C8; // float
        public const Int32 reloadEndDuration = 0x2CC; // float
        public const Int32 aimSway = 0x2D0; // float
        public const Int32 aimSwaySpeed = 0x2D4; // float
        public const Int32 recoil = 0x2D8; // RecoilProperties
        public const Int32 aimconeCurve = 0x2E0; // AnimationCurve
        public const Int32 aimCone = 0x2E8; // float
        public const Int32 hipAimCone = 0x2EC; // float
        public const Int32 aimconePenaltyPerShot = 0x2F0; // float
        public const Int32 aimConePenaltyMax = 0x2F4; // float
        public const Int32 aimconePenaltyRecoverTime = 0x2F8; // float
        public const Int32 aimconePenaltyRecoverDelay = 0x2FC; // float
        public const Int32 stancePenaltyScale = 0x300; // float
        public const Int32 hasADS = 0x304; // bool
        public const Int32 noAimingWhileCycling = 0x305; // bool
        public const Int32 manualCycle = 0x306; // bool
        public const Int32 needsCycle = 0x307; // bool
        public const Int32 isCycling = 0x308; // bool
        public const Int32 aiming = 0x309; // bool
        public const Int32 resetDuration = 0x30C; // float
        public const Int32 numShotsFired = 0x310; // int
        public const Int32 nextReloadTime = 0x314; // float
        public const Int32 startReloadTime = 0x318; // float
        public const Int32 stancePenalty = 0x31C; // float
        public const Int32 aimconePenalty = 0x320; // float
        public const Int32 isReloading = 0x324; // bool
        public const Int32 swaySampleTime = 0x328; // float
        public const Int32 lastShotTime = 0x32C; // float
        public const Int32 reloadPressTime = 0x330; // float
        public const Int32 ammoTypePreReload = 0x338; // ItemDefinition
        public const Int32 fractionalReloadDesiredCount = 0x340; // int
        public const Int32 fractionalReloadNumAdded = 0x344; // int
        public const Int32 triggerReady = 0x348; // bool
        public const Int32 nextHeightCheckTime = 0x34C; // float
        public const Int32 cachedUnderground = 0x350; // bool
        public const Int32 createdProjectiles = 0x358; // List<Projectile>
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
        public const Int32 _smoothAimWeight = 0x18; // float
        public const Int32 _smoothVelocity = 0x1C; // float
        public const Int32 _smoothlookAngle = 0x20; // Vector3
        public const Int32 allowMountedHeadLook = 0x2C; // bool
        public const Int32 smoothLookDir = 0x30; // Vector3
        public const Int32 lastSafeLookDir = 0x3C; // Vector3
        public const Int32 Shoulders = 0x48; // Transform[]
        public const Int32 AdditionalSpineBones = 0x50; // Transform[]
        public const Int32 LegParts = 0x58; // List<SkinnedMeshRenderer>
        public const Int32 fakeSpineBones = 0x60; // Transform[]
        public const Int32 extraLeanBack = 0x68; // float
        public const Int32 timeInArmsMode = 0x70; // float
        public const Int32 collision = 0x78; // BoxCollider
        public const Int32 censorshipCube = 0x80; // GameObject
        public const Int32 censorshipCubeBreasts = 0x88; // GameObject
        public const Int32 jawBone = 0x90; // GameObject
        public const Int32 neckBone = 0x98; // GameObject
        public const Int32 headBone = 0xA0; // GameObject
        public const Int32 eyeController = 0xA8; // EyeController
        public const Int32 blinkController = 0xB0; // EyeBlink
        public const Int32 SpineBones = 0xB8; // Transform[]
        public const Int32 leftFootBone = 0xC0; // Transform
        public const Int32 rightFootBone = 0xC8; // Transform
        public const Int32 leftHandPropBone = 0xD0; // Transform
        public const Int32 rightHandPropBone = 0xD8; // Transform
        public const Int32 rightHandTarget = 0xE0; // Vector3
        public const Int32 leftHandTargetPosition = 0xEC; // Vector3
        public const Int32 leftHandTargetRotation = 0xF8; // Quaternion
        public const Int32 rightHandTargetPosition = 0x108; // Vector3
        public const Int32 rightHandTargetRotation = 0x114; // Quaternion
        public const Int32 steeringTargetDegrees = 0x124; // float
        public const Int32 rightFootTargetPosition = 0x128; // Vector3
        public const Int32 rightFootTargetRotation = 0x134; // Quaternion
        public const Int32 leftFootTargetPosition = 0x144; // Vector3
        public const Int32 leftFootTargetRotation = 0x150; // Quaternion
        public const Int32 CinematicAnimationController = 0x160; // RuntimeAnimatorController
        public const Int32 DefaultAvatar = 0x168; // Avatar
        public const Int32 CinematicAvatar = 0x170; // Avatar
        public const Int32 DefaultHoldType = 0x178; // RuntimeAnimatorController
        public const Int32 SleepGesture = 0x180; // RuntimeAnimatorController
        public const Int32 CrawlToIncapacitatedGesture = 0x188; // RuntimeAnimatorController
        public const Int32 StandToIncapacitatedGesture = 0x190; // RuntimeAnimatorController
        public const Int32 CurrentGesture = 0x198; // RuntimeAnimatorController
        public const Int32 MaleSkin = 0x1A0; // SkinSetCollection
        public const Int32 FemaleSkin = 0x1A8; // SkinSetCollection
        public const Int32 subsurfaceProfile = 0x1B0; // SubsurfaceProfile
        public const Int32 voiceVolume = 0x1B8; // float
        public const Int32 skinColor = 0x1BC; // float
        public const Int32 skinNumber = 0x1C0; // float
        public const Int32 meshNumber = 0x1C4; // float
        public const Int32 hairNumber = 0x1C8; // float
        public const Int32 skinType = 0x1CC; // int
        public const Int32 movementSounds = 0x1D0; // MovementSounds
        public const Int32 showSash = 0x1D8; // bool
        public const Int32 tempPoseType = 0x1DC; // int
        public const Int32 underwearSkin = 0x1E0; // uint
        public const Int32 overrideSkinSeed = 0x1E8; // ulong
        public const Int32 AimAngles = 0x1F0; // Quaternion
        public const Int32 LookAngles = 0x200; // Quaternion
        public const Int32 modelState = 0x210; // ModelState
        public const Int32 position = 0x218; // Vector3
        public const Int32 velocity = 0x224; // Vector3
        public const Int32 speedOverride = 0x230; // Vector3
        public const Int32 newVelocity = 0x23C; // Vector3
        public const Int32 rotation = 0x248; // Quaternion
        public const Int32 mountedRotation = 0x258; // Quaternion
        public const Int32 smoothLeftFootIK = 0x268; // Vector3
        public const Int32 smoothRightFootIK = 0x274; // Vector3
        public const Int32 drawShadowOnly = 0x280; // bool
        public const Int32 isIncapacitated = 0x281; // bool
        public const Int32 flinchLocation = 0x284; // uint
        public const Int32 visible = 0x288; // bool
        public const Int32 nameTag = 0x290; // PlayerNameTag
        public const Int32 animatorNeedsWarmup = 0x298; // bool
        public const Int32 isLocalPlayer = 0x299; // bool
        public const Int32 aimSoundDef = 0x2A0; // SoundDefinition
        public const Int32 aimEndSoundDef = 0x2A8; // SoundDefinition
        public const Int32 InGesture = 0x2B0; // bool
        public const Int32 CurrentGestureConfig = 0x2B8; // GestureConfig
        public const Int32 InCinematic = 0x2C0; // bool
        public const Int32 defaultAnimatorController = 0x2C8; // RuntimeAnimatorController
        public const Int32 _multiMesh = 0x2D0; // SkinnedMultiMesh
        public const Int32 _animator = 0x2D8; // Animator
        public const Int32 _lodGroup = 0x2E0; // LODGroup
        public const Int32 _currentGesture = 0x2E8; // RuntimeAnimatorController
        public const Int32 holdTypeLock = 0x2F0; // float
        public const Int32 wasMountedRightAim = 0x2F4; // bool
        public const Int32 cachedMask = 0x2F8; // int
        public const Int32 cachedConstructionMask = 0x2FC; // int
        public const Int32 WorkshopHeldEntity = 0x300; // HeldEntity
        public const Int32 wasCrawling = 0x308; // bool
        public const Int32 mountedSpineLookWeight = 0x30C; // float
        public const Int32 mountedAnimSpeed = 0x310; // float
        public const Int32 preserveBones = 0x314; // bool
        public const Int32 IsNpc = 0x320; // bool
        public const Int32 timeSinceReactionStart = 0x324; // TimeSince
        public const Int32 timeSinceLeftFootTest = 0x328; // TimeSince
        public const Int32 cachedLeftFootPos = 0x32C; // Vector3
        public const Int32 cachedLeftFootNormal = 0x338; // Vector3
        public const Int32 timeSinceRightFootTest = 0x344; // TimeSince
        public const Int32 cachedRightFootPos = 0x348; // Vector3
        public const Int32 cachedRightFootNormal = 0x354; // Vector3
    }
    public static class ModelState
    {
        public const Int32 ShouldPool = 0x10; // bool
        public const Int32 _disposed = 0x11; // bool
        public const Int32 waterLevel = 0x14; // float
        public const Int32 lookDir = 0x18; // Vector3
        public const Int32 flags = 0x24; // int
        public const Int32 poseType = 0x28; // int
        public const Int32 inheritedVelocity = 0x2C; // Vector3
    }
    public static class Item
    {
        public const Int32 _condition = 0x18; // float
        public const Int32 _maxCondition = 0x1C; // float
        public const Int32 info = 0x20; // ItemDefinition
        public const Int32 uid = 0x28; // uint
        public const Int32 dirty = 0x2C; // bool
        public const Int32 amount = 0x30; // int
        public const Int32 position = 0x34; // int
        public const Int32 busyTime = 0x38; // float
        public const Int32 removeTime = 0x3C; // float
        public const Int32 fuel = 0x40; // float
        public const Int32 isServer = 0x44; // bool
        public const Int32 instanceData = 0x48; // Item.InstanceData
        public const Int32 skin = 0x50; // ulong
        public const Int32 name = 0x58; // string
        public const Int32 text = 0x60; // string
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
} // namespace blazedumper
