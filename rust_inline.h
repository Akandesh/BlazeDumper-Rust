#pragma once
#include <cstdint>

namespace blazedumper {
    namespace BaseCombatEntity {
        inline constexpr ::std::ptrdiff_t ShowHealthInfo = 0x218; 
        inline constexpr ::std::ptrdiff_t __menuOption_Menu_Pickup = 0x160; 
        inline constexpr ::std::ptrdiff_t _health = 0x224; 
        inline constexpr ::std::ptrdiff_t _maxHealth = 0x228; 
        inline constexpr ::std::ptrdiff_t baseProtection = 0x1C0; 
        inline constexpr ::std::ptrdiff_t deathTime = 0x230; 
        inline constexpr ::std::ptrdiff_t faction = 0x22C; 
        inline constexpr ::std::ptrdiff_t lastNotifyFrame = 0x234; 
        inline constexpr ::std::ptrdiff_t lifestate = 0x21C; 
        inline constexpr ::std::ptrdiff_t markAttackerHostile = 0x222; 
        inline constexpr ::std::ptrdiff_t pickup = 0x1D0; 
        inline constexpr ::std::ptrdiff_t repair = 0x1F0; 
        inline constexpr ::std::ptrdiff_t sendsHitNotification = 0x220; 
        inline constexpr ::std::ptrdiff_t sendsMeleeHitNotification = 0x221; 
        inline constexpr ::std::ptrdiff_t skeletonProperties = 0x1B8; 
        inline constexpr ::std::ptrdiff_t startHealth = 0x1C8; 
    } // namespace BaseCombatEntity
    namespace BaseEntity {
        inline constexpr ::std::ptrdiff_t HasBrain = 0x148; 
        inline constexpr ::std::ptrdiff_t OwnerID = 0x158; 
        inline constexpr ::std::ptrdiff_t Weight = 0xF8; 
        inline constexpr ::std::ptrdiff_t _components = 0x140; 
        inline constexpr ::std::ptrdiff_t _name = 0x150; 
        inline constexpr ::std::ptrdiff_t _pendingFileRequestsList = 0xA0; 
        inline constexpr ::std::ptrdiff_t addedToParentEntity = 0xB0; 
        inline constexpr ::std::ptrdiff_t bounds = 0xFC; 
        inline constexpr ::std::ptrdiff_t broadcastProtocol = 0x88; 
        inline constexpr ::std::ptrdiff_t enableSaving = 0x120; 
        inline constexpr ::std::ptrdiff_t entitySlots = 0xC0; 
        inline constexpr ::std::ptrdiff_t flags = 0x130; 
        inline constexpr ::std::ptrdiff_t impactEffect = 0x118; 
        inline constexpr ::std::ptrdiff_t isAnimatorVisible = 0xD1; 
        inline constexpr ::std::ptrdiff_t isShadowVisible = 0xD2; 
        inline constexpr ::std::ptrdiff_t isVisible = 0xD0; 
        inline constexpr ::std::ptrdiff_t itemSkin = 0xB8; 
        inline constexpr ::std::ptrdiff_t linkedToNeighbours = 0x98; 
        inline constexpr ::std::ptrdiff_t linksList = 0x90; 
        inline constexpr ::std::ptrdiff_t localOccludee = 0xD8; 
        inline constexpr ::std::ptrdiff_t menuOptionsList = 0x80; 
        inline constexpr ::std::ptrdiff_t model = 0x128; 
        inline constexpr ::std::ptrdiff_t parentBone = 0x134; 
        inline constexpr ::std::ptrdiff_t positionLerp = 0x78; 
        inline constexpr ::std::ptrdiff_t ragdoll = 0x70; 
        inline constexpr ::std::ptrdiff_t skinID = 0x138; 
        inline constexpr ::std::ptrdiff_t syncPosition = 0x121; 
        inline constexpr ::std::ptrdiff_t triggersList = 0xC8; 
        inline constexpr ::std::ptrdiff_t updateParentingAction = 0xA8; 
    } // namespace BaseEntity
    inline constexpr ::std::ptrdiff_t BaseEntity_TypeInfo = 0x52240584;
    namespace BasePlayer {
        inline constexpr ::std::ptrdiff_t Belt = 0x6B0; 
        inline constexpr ::std::ptrdiff_t ClientCurrentDeathNote = 0x5D8; 
        inline constexpr ::std::ptrdiff_t ClientCurrentMapNote = 0x5D0; 
        inline constexpr ::std::ptrdiff_t Frozen = 0x4C8; 
        inline constexpr ::std::ptrdiff_t GestureViewModel = 0x530; 
        inline constexpr ::std::ptrdiff_t IsWearingDiveGoggles = 0x528; 
        inline constexpr ::std::ptrdiff_t PetEntity = 0x610; 
        inline constexpr ::std::ptrdiff_t PetID = 0x620; 
        inline constexpr ::std::ptrdiff_t PetPrefabID = 0x61C; 
        inline constexpr ::std::ptrdiff_t UserIDString = 0x6C8; 
        inline constexpr ::std::ptrdiff_t __menuOption_Climb = 0x238; 
        inline constexpr ::std::ptrdiff_t __menuOption_Drink = 0x290; 
        inline constexpr ::std::ptrdiff_t __menuOption_InviteToTeam = 0x2E8; 
        inline constexpr ::std::ptrdiff_t __menuOption_Menu_AssistPlayer = 0x340; 
        inline constexpr ::std::ptrdiff_t __menuOption_Menu_LootPlayer = 0x398; 
        inline constexpr ::std::ptrdiff_t __menuOption_Promote = 0x3F0; 
        inline constexpr ::std::ptrdiff_t __menuOption_SaltWater = 0x448; 
        inline constexpr ::std::ptrdiff_t _activeMission = 0x5E8; 
        inline constexpr ::std::ptrdiff_t _displayName = 0x6D8; 
        inline constexpr ::std::ptrdiff_t _lastSetName = 0x6E0; 
        inline constexpr ::std::ptrdiff_t _lookingAt = 0x4F8; 
        inline constexpr ::std::ptrdiff_t _lookingAtCollider = 0x508; 
        inline constexpr ::std::ptrdiff_t _lookingAtEntity = 0x500; 
        inline constexpr ::std::ptrdiff_t activeTelephone = 0x760; 
        inline constexpr ::std::ptrdiff_t blockHeldInputTimer = 0x56C; 
        inline constexpr ::std::ptrdiff_t blueprints = 0x690; 
        inline constexpr ::std::ptrdiff_t cachedBuildingPrivilege = 0x628; 
        inline constexpr ::std::ptrdiff_t cachedBuildingPrivilegeTime = 0x624; 
        inline constexpr ::std::ptrdiff_t cachedProtection = 0x738; 
        inline constexpr ::std::ptrdiff_t cachedThreatLevel = 0x638; 
        inline constexpr ::std::ptrdiff_t cachedWaterDrinkingPoint = 0x550; 
        inline constexpr ::std::ptrdiff_t clActiveItem = 0x5C8; 
        inline constexpr ::std::ptrdiff_t clientTeam = 0x598; 
        inline constexpr ::std::ptrdiff_t clientTickInterval = 0x648; 
        inline constexpr ::std::ptrdiff_t clientTickRate = 0x640; 
        inline constexpr ::std::ptrdiff_t client_lastHelloTime = 0x588; 
        inline constexpr ::std::ptrdiff_t clothingAccuracyBonus = 0x754; 
        inline constexpr ::std::ptrdiff_t clothingBlocksAiming = 0x748; 
        inline constexpr ::std::ptrdiff_t clothingMoveSpeedReduction = 0x74C; 
        inline constexpr ::std::ptrdiff_t clothingWaterSpeedBonus = 0x750; 
        inline constexpr ::std::ptrdiff_t collision = 0x4F0; 
        inline constexpr ::std::ptrdiff_t currentGesture = 0x570; 
        inline constexpr ::std::ptrdiff_t currentTeam = 0x590; 
        inline constexpr ::std::ptrdiff_t currentViewMode = 0x4A0; 
        inline constexpr ::std::ptrdiff_t debugPrevVisible = 0x660; 
        inline constexpr ::std::ptrdiff_t designingAIEntity = 0x768; 
        inline constexpr ::std::ptrdiff_t disabledHeldEntity = 0x578; 
        inline constexpr ::std::ptrdiff_t drownEffect = 0x670; 
        inline constexpr ::std::ptrdiff_t eggVision = 0x75C; 
        inline constexpr ::std::ptrdiff_t equippingBlocked = 0x758; 
        inline constexpr ::std::ptrdiff_t eyes = 0x680; 
        inline constexpr ::std::ptrdiff_t fallDamageEffect = 0x668; 
        inline constexpr ::std::ptrdiff_t gamemodeteam = 0x6D0; 
        inline constexpr ::std::ptrdiff_t gestureFinishedTime = 0x568; 
        inline constexpr ::std::ptrdiff_t gestureList = 0x560; 
        inline constexpr ::std::ptrdiff_t input = 0x4E0; 
        inline constexpr ::std::ptrdiff_t inventory = 0x688; 
        inline constexpr ::std::ptrdiff_t lastClothesHash = 0x524; 
        inline constexpr ::std::ptrdiff_t lastGestureCancel = 0x584; 
        inline constexpr ::std::ptrdiff_t lastHeadshotSoundTime = 0x740; 
        inline constexpr ::std::ptrdiff_t lastPetCommandIssuedTime = 0x618; 
        inline constexpr ::std::ptrdiff_t lastPresenceTeamId = 0x5A8; 
        inline constexpr ::std::ptrdiff_t lastPresenceTeamSize = 0x5B0; 
        inline constexpr ::std::ptrdiff_t lastReceivedTeamTime = 0x5A0; 
        inline constexpr ::std::ptrdiff_t lastReviveDirection = 0x4B4; 
        inline constexpr ::std::ptrdiff_t lastRevivePoint = 0x4A8; 
        inline constexpr ::std::ptrdiff_t lastSentTick = 0x650; 
        inline constexpr ::std::ptrdiff_t lastSentTickTime = 0x64C; 
        inline constexpr ::std::ptrdiff_t lastTimeSeen = 0x65C; 
        inline constexpr ::std::ptrdiff_t lastUpdateTime = 0x634; 
        inline constexpr ::std::ptrdiff_t lookingAtPoint = 0x510; 
        inline constexpr ::std::ptrdiff_t lookingAtTest = 0x548; 
        inline constexpr ::std::ptrdiff_t maxProjectileID = 0x630; 
        inline constexpr ::std::ptrdiff_t metabolism = 0x698; 
        inline constexpr ::std::ptrdiff_t missionsList = 0x5E0; 
        inline constexpr ::std::ptrdiff_t modelState = 0x5F0; 
        inline constexpr ::std::ptrdiff_t modifiers = 0x6A0; 
        inline constexpr ::std::ptrdiff_t mounted = 0x5F8; 
        inline constexpr ::std::ptrdiff_t movement = 0x4E8; 
        inline constexpr ::std::ptrdiff_t needsClothesRebuild = 0x520; 
        inline constexpr ::std::ptrdiff_t nextColliderRefreshTime = 0x744; 
        inline constexpr ::std::ptrdiff_t nextGestureMenuOpenTime = 0x580; 
        inline constexpr ::std::ptrdiff_t nextSeatSwapTime = 0x608; 
        inline constexpr ::std::ptrdiff_t nextTopologyTestTime = 0x53C; 
        inline constexpr ::std::ptrdiff_t nextVisThink = 0x658; 
        inline constexpr ::std::ptrdiff_t playerCollider = 0x6A8; 
        inline constexpr ::std::ptrdiff_t playerColliderCrawling = 0x710; 
        inline constexpr ::std::ptrdiff_t playerColliderDucked = 0x6FC; 
        inline constexpr ::std::ptrdiff_t playerColliderLyingDown = 0x724; 
        inline constexpr ::std::ptrdiff_t playerColliderStanding = 0x6E8; 
        inline constexpr ::std::ptrdiff_t playerFlags = 0x678; 
        inline constexpr ::std::ptrdiff_t playerGroupKey = 0x5B8; 
        inline constexpr ::std::ptrdiff_t playerGroupSizeKey = 0x5C0; 
        inline constexpr ::std::ptrdiff_t playerModel = 0x4C0; 
        inline constexpr ::std::ptrdiff_t playerRigidbody = 0x6B8; 
        inline constexpr ::std::ptrdiff_t reputation = 0x6D4; 
        inline constexpr ::std::ptrdiff_t selectedViewMode = 0x4A4; 
        inline constexpr ::std::ptrdiff_t serverTickInterval = 0x644; 
        inline constexpr ::std::ptrdiff_t serverTickRate = 0x63C; 
        inline constexpr ::std::ptrdiff_t timeSinceUpdatedLookingAt = 0x538; 
        inline constexpr ::std::ptrdiff_t useHeldTime = 0x544; 
        inline constexpr ::std::ptrdiff_t usePressTime = 0x540; 
        inline constexpr ::std::ptrdiff_t userID = 0x6C0; 
        inline constexpr ::std::ptrdiff_t voiceRecorder = 0x4D0; 
        inline constexpr ::std::ptrdiff_t voiceSpeaker = 0x4D8; 
        inline constexpr ::std::ptrdiff_t wakeTime = 0x51C; 
        inline constexpr ::std::ptrdiff_t wasDead = 0x523; 
        inline constexpr ::std::ptrdiff_t wasSleeping = 0x521; 
        inline constexpr ::std::ptrdiff_t wokeUpBefore = 0x522; 
    } // namespace BasePlayer
    namespace BaseProjectile {
        inline constexpr ::std::ptrdiff_t MuzzlePoint = 0x2A8; 
        inline constexpr ::std::ptrdiff_t NoiseRadius = 0x278; 
        inline constexpr ::std::ptrdiff_t aimCone = 0x2E8; 
        inline constexpr ::std::ptrdiff_t aimConePenaltyMax = 0x2F4; 
        inline constexpr ::std::ptrdiff_t aimSway = 0x2D0; 
        inline constexpr ::std::ptrdiff_t aimSwaySpeed = 0x2D4; 
        inline constexpr ::std::ptrdiff_t aimconeCurve = 0x2E0; 
        inline constexpr ::std::ptrdiff_t aimconePenalty = 0x320; 
        inline constexpr ::std::ptrdiff_t aimconePenaltyPerShot = 0x2F0; 
        inline constexpr ::std::ptrdiff_t aimconePenaltyRecoverDelay = 0x2FC; 
        inline constexpr ::std::ptrdiff_t aimconePenaltyRecoverTime = 0x2F8; 
        inline constexpr ::std::ptrdiff_t aiming = 0x309; 
        inline constexpr ::std::ptrdiff_t ammoTypePreReload = 0x338; 
        inline constexpr ::std::ptrdiff_t attackFX = 0x290; 
        inline constexpr ::std::ptrdiff_t automatic = 0x288; 
        inline constexpr ::std::ptrdiff_t cachedUnderground = 0x350; 
        inline constexpr ::std::ptrdiff_t canUnloadAmmo = 0x2B4; 
        inline constexpr ::std::ptrdiff_t createdProjectilesList = 0x358; 
        inline constexpr ::std::ptrdiff_t damageScale = 0x27C; 
        inline constexpr ::std::ptrdiff_t distanceScale = 0x280; 
        inline constexpr ::std::ptrdiff_t fractionalReload = 0x2C0; 
        inline constexpr ::std::ptrdiff_t fractionalReloadDesiredCount = 0x340; 
        inline constexpr ::std::ptrdiff_t fractionalReloadNumAdded = 0x344; 
        inline constexpr ::std::ptrdiff_t hasADS = 0x304; 
        inline constexpr ::std::ptrdiff_t hipAimCone = 0x2EC; 
        inline constexpr ::std::ptrdiff_t isCycling = 0x308; 
        inline constexpr ::std::ptrdiff_t isReloading = 0x324; 
        inline constexpr ::std::ptrdiff_t lastShotTime = 0x32C; 
        inline constexpr ::std::ptrdiff_t manualCycle = 0x306; 
        inline constexpr ::std::ptrdiff_t muzzleBrakeAttack = 0x2A0; 
        inline constexpr ::std::ptrdiff_t needsCycle = 0x307; 
        inline constexpr ::std::ptrdiff_t nextHeightCheckTime = 0x34C; 
        inline constexpr ::std::ptrdiff_t nextReloadTime = 0x314; 
        inline constexpr ::std::ptrdiff_t noAimingWhileCycling = 0x305; 
        inline constexpr ::std::ptrdiff_t numShotsFired = 0x310; 
        inline constexpr ::std::ptrdiff_t primaryMagazine = 0x2B8; 
        inline constexpr ::std::ptrdiff_t projectileVelocityScale = 0x284; 
        inline constexpr ::std::ptrdiff_t recoil = 0x2D8; 
        inline constexpr ::std::ptrdiff_t reloadEndDuration = 0x2CC; 
        inline constexpr ::std::ptrdiff_t reloadFractionDuration = 0x2C8; 
        inline constexpr ::std::ptrdiff_t reloadPressTime = 0x330; 
        inline constexpr ::std::ptrdiff_t reloadStartDuration = 0x2C4; 
        inline constexpr ::std::ptrdiff_t reloadTime = 0x2B0; 
        inline constexpr ::std::ptrdiff_t resetDuration = 0x30C; 
        inline constexpr ::std::ptrdiff_t silencedAttack = 0x298; 
        inline constexpr ::std::ptrdiff_t stancePenalty = 0x31C; 
        inline constexpr ::std::ptrdiff_t stancePenaltyScale = 0x300; 
        inline constexpr ::std::ptrdiff_t startReloadTime = 0x318; 
        inline constexpr ::std::ptrdiff_t swaySampleTime = 0x328; 
        inline constexpr ::std::ptrdiff_t triggerReady = 0x348; 
        inline constexpr ::std::ptrdiff_t turretDamageScale = 0x28C; 
        inline constexpr ::std::ptrdiff_t usableByTurret = 0x289; 
    } // namespace BaseProjectile
    namespace BuildingPrivledge {
        inline constexpr ::std::ptrdiff_t __menuOption_MenuAuthorize = 0x478; 
        inline constexpr ::std::ptrdiff_t __menuOption_MenuClearList = 0x4D0; 
        inline constexpr ::std::ptrdiff_t __menuOption_MenuDeauthorize = 0x528; 
        inline constexpr ::std::ptrdiff_t __menuOption_Menu_MaxAuth = 0x3C8; 
        inline constexpr ::std::ptrdiff_t __menuOption_Menu_RotateVM = 0x420; 
        inline constexpr ::std::ptrdiff_t allowedConstructionItemsList = 0x598; 
        inline constexpr ::std::ptrdiff_t authorizedPlayersList = 0x590; 
        inline constexpr ::std::ptrdiff_t cachedProtectedMinutes = 0x580; 
        inline constexpr ::std::ptrdiff_t cachedUpkeepCostFraction = 0x588; 
        inline constexpr ::std::ptrdiff_t cachedUpkeepPeriodMinutes = 0x584; 
    } // namespace BuildingPrivledge
    inline constexpr ::std::ptrdiff_t Facepunch_Input_TypeInfo = 0x52314552;
    namespace Item {
        inline constexpr ::std::ptrdiff_t _condition = 0x18; 
        inline constexpr ::std::ptrdiff_t _maxCondition = 0x1C; 
        inline constexpr ::std::ptrdiff_t amount = 0x30; 
        inline constexpr ::std::ptrdiff_t busyTime = 0x38; 
        inline constexpr ::std::ptrdiff_t contents = 0x78; 
        inline constexpr ::std::ptrdiff_t dirty = 0x2C; 
        inline constexpr ::std::ptrdiff_t flags = 0x70; 
        inline constexpr ::std::ptrdiff_t fuel = 0x40; 
        inline constexpr ::std::ptrdiff_t heldEntity = 0x98; 
        inline constexpr ::std::ptrdiff_t info = 0x20; 
        inline constexpr ::std::ptrdiff_t instanceData = 0x48; 
        inline constexpr ::std::ptrdiff_t isServer = 0x44; 
        inline constexpr ::std::ptrdiff_t name = 0x58; 
        inline constexpr ::std::ptrdiff_t parent = 0x80; 
        inline constexpr ::std::ptrdiff_t position = 0x34; 
        inline constexpr ::std::ptrdiff_t removeTime = 0x3C; 
        inline constexpr ::std::ptrdiff_t skin = 0x50; 
        inline constexpr ::std::ptrdiff_t text = 0x60; 
        inline constexpr ::std::ptrdiff_t uid = 0x28; 
        inline constexpr ::std::ptrdiff_t worldEnt = 0x88; 
    } // namespace Item
    namespace ItemContainer {
        inline constexpr ::std::ptrdiff_t allowedContents = 0x14; 
        inline constexpr ::std::ptrdiff_t availableSlotsList = 0x20; 
        inline constexpr ::std::ptrdiff_t capacity = 0x28; 
        inline constexpr ::std::ptrdiff_t dirty = 0x30; 
        inline constexpr ::std::ptrdiff_t entityOwner = 0x58; 
        inline constexpr ::std::ptrdiff_t flags = 0x10; 
        inline constexpr ::std::ptrdiff_t isServer = 0x60; 
        inline constexpr ::std::ptrdiff_t itemList = 0x38; 
        inline constexpr ::std::ptrdiff_t maxStackSize = 0x64; 
        inline constexpr ::std::ptrdiff_t onlyAllowedItems = 0x18; 
        inline constexpr ::std::ptrdiff_t parent = 0x48; 
        inline constexpr ::std::ptrdiff_t playerOwner = 0x50; 
        inline constexpr ::std::ptrdiff_t temperature = 0x40; 
        inline constexpr ::std::ptrdiff_t uid = 0x2C; 
    } // namespace ItemContainer
    namespace Magazine {
        inline constexpr ::std::ptrdiff_t ammoType = 0x20; 
        inline constexpr ::std::ptrdiff_t capacity = 0x18; 
        inline constexpr ::std::ptrdiff_t contents = 0x1C; 
        inline constexpr ::std::ptrdiff_t definition = 0x10; 
    } // namespace Magazine
    inline constexpr ::std::ptrdiff_t MainCamera_TypeInfo = 0x52247536;
    namespace Model {
        inline constexpr ::std::ptrdiff_t _lodGroup = 0x68; 
        inline constexpr ::std::ptrdiff_t animator = 0x38; 
        inline constexpr ::std::ptrdiff_t boneDict = 0x58; 
        inline constexpr ::std::ptrdiff_t boneNames = 0x50; 
        inline constexpr ::std::ptrdiff_t boneTransforms = 0x48; 
        inline constexpr ::std::ptrdiff_t collision = 0x18; 
        inline constexpr ::std::ptrdiff_t eyeBone = 0x30; 
        inline constexpr ::std::ptrdiff_t headBone = 0x28; 
        inline constexpr ::std::ptrdiff_t rootBone = 0x20; 
        inline constexpr ::std::ptrdiff_t skeleton = 0x40; 
        inline constexpr ::std::ptrdiff_t skin = 0x60; 
    } // namespace Model
    namespace ModelState {
        inline constexpr ::std::ptrdiff_t ShouldPool = 0x10; 
        inline constexpr ::std::ptrdiff_t _disposed = 0x11; 
        inline constexpr ::std::ptrdiff_t flags = 0x24; 
        inline constexpr ::std::ptrdiff_t inheritedVelocity = 0x2C; 
        inline constexpr ::std::ptrdiff_t lookDir = 0x18; 
        inline constexpr ::std::ptrdiff_t poseType = 0x28; 
        inline constexpr ::std::ptrdiff_t waterLevel = 0x14; 
    } // namespace ModelState
    namespace PlayerInventory {
        inline constexpr ::std::ptrdiff_t containerBelt = 0x28; 
        inline constexpr ::std::ptrdiff_t containerMain = 0x20; 
        inline constexpr ::std::ptrdiff_t containerWear = 0x30; 
        inline constexpr ::std::ptrdiff_t crafting = 0x38; 
        inline constexpr ::std::ptrdiff_t loot = 0x40; 
    } // namespace PlayerInventory
    namespace PlayerModel {
        inline constexpr ::std::ptrdiff_t AdditionalSpineBones = 0x50; 
        inline constexpr ::std::ptrdiff_t AimAngles = 0x1F0; 
        inline constexpr ::std::ptrdiff_t CinematicAnimationController = 0x160; 
        inline constexpr ::std::ptrdiff_t CinematicAvatar = 0x170; 
        inline constexpr ::std::ptrdiff_t CrawlToIncapacitatedGesture = 0x188; 
        inline constexpr ::std::ptrdiff_t CurrentGesture = 0x198; 
        inline constexpr ::std::ptrdiff_t CurrentGestureConfig = 0x2B8; 
        inline constexpr ::std::ptrdiff_t DefaultAvatar = 0x168; 
        inline constexpr ::std::ptrdiff_t DefaultHoldType = 0x178; 
        inline constexpr ::std::ptrdiff_t FemaleSkin = 0x1A8; 
        inline constexpr ::std::ptrdiff_t InCinematic = 0x2C0; 
        inline constexpr ::std::ptrdiff_t InGesture = 0x2B0; 
        inline constexpr ::std::ptrdiff_t IsNpc = 0x320; 
        inline constexpr ::std::ptrdiff_t LegPartsList = 0x58; 
        inline constexpr ::std::ptrdiff_t LookAngles = 0x200; 
        inline constexpr ::std::ptrdiff_t MaleSkin = 0x1A0; 
        inline constexpr ::std::ptrdiff_t Shoulders = 0x48; 
        inline constexpr ::std::ptrdiff_t SleepGesture = 0x180; 
        inline constexpr ::std::ptrdiff_t SpineBones = 0xB8; 
        inline constexpr ::std::ptrdiff_t StandToIncapacitatedGesture = 0x190; 
        inline constexpr ::std::ptrdiff_t WorkshopHeldEntity = 0x300; 
        inline constexpr ::std::ptrdiff_t _animator = 0x2D8; 
        inline constexpr ::std::ptrdiff_t _currentGesture = 0x2E8; 
        inline constexpr ::std::ptrdiff_t _lodGroup = 0x2E0; 
        inline constexpr ::std::ptrdiff_t _multiMesh = 0x2D0; 
        inline constexpr ::std::ptrdiff_t _smoothAimWeight = 0x18; 
        inline constexpr ::std::ptrdiff_t _smoothVelocity = 0x1C; 
        inline constexpr ::std::ptrdiff_t _smoothlookAngle = 0x20; 
        inline constexpr ::std::ptrdiff_t aimEndSoundDef = 0x2A8; 
        inline constexpr ::std::ptrdiff_t aimSoundDef = 0x2A0; 
        inline constexpr ::std::ptrdiff_t allowMountedHeadLook = 0x2C; 
        inline constexpr ::std::ptrdiff_t animatorNeedsWarmup = 0x298; 
        inline constexpr ::std::ptrdiff_t blinkController = 0xB0; 
        inline constexpr ::std::ptrdiff_t cachedConstructionMask = 0x2FC; 
        inline constexpr ::std::ptrdiff_t cachedLeftFootNormal = 0x338; 
        inline constexpr ::std::ptrdiff_t cachedLeftFootPos = 0x32C; 
        inline constexpr ::std::ptrdiff_t cachedMask = 0x2F8; 
        inline constexpr ::std::ptrdiff_t cachedRightFootNormal = 0x354; 
        inline constexpr ::std::ptrdiff_t cachedRightFootPos = 0x348; 
        inline constexpr ::std::ptrdiff_t censorshipCube = 0x80; 
        inline constexpr ::std::ptrdiff_t censorshipCubeBreasts = 0x88; 
        inline constexpr ::std::ptrdiff_t collision = 0x78; 
        inline constexpr ::std::ptrdiff_t defaultAnimatorController = 0x2C8; 
        inline constexpr ::std::ptrdiff_t drawShadowOnly = 0x280; 
        inline constexpr ::std::ptrdiff_t extraLeanBack = 0x68; 
        inline constexpr ::std::ptrdiff_t eyeController = 0xA8; 
        inline constexpr ::std::ptrdiff_t fakeSpineBones = 0x60; 
        inline constexpr ::std::ptrdiff_t flinchLocation = 0x284; 
        inline constexpr ::std::ptrdiff_t hairNumber = 0x1C8; 
        inline constexpr ::std::ptrdiff_t headBone = 0xA0; 
        inline constexpr ::std::ptrdiff_t holdTypeLock = 0x2F0; 
        inline constexpr ::std::ptrdiff_t isIncapacitated = 0x281; 
        inline constexpr ::std::ptrdiff_t isLocalPlayer = 0x299; 
        inline constexpr ::std::ptrdiff_t jawBone = 0x90; 
        inline constexpr ::std::ptrdiff_t lastSafeLookDir = 0x3C; 
        inline constexpr ::std::ptrdiff_t leftFootBone = 0xC0; 
        inline constexpr ::std::ptrdiff_t leftFootTargetPosition = 0x144; 
        inline constexpr ::std::ptrdiff_t leftFootTargetRotation = 0x150; 
        inline constexpr ::std::ptrdiff_t leftHandPropBone = 0xD0; 
        inline constexpr ::std::ptrdiff_t leftHandTargetPosition = 0xEC; 
        inline constexpr ::std::ptrdiff_t leftHandTargetRotation = 0xF8; 
        inline constexpr ::std::ptrdiff_t meshNumber = 0x1C4; 
        inline constexpr ::std::ptrdiff_t modelState = 0x210; 
        inline constexpr ::std::ptrdiff_t mountedAnimSpeed = 0x310; 
        inline constexpr ::std::ptrdiff_t mountedRotation = 0x258; 
        inline constexpr ::std::ptrdiff_t mountedSpineLookWeight = 0x30C; 
        inline constexpr ::std::ptrdiff_t movementSounds = 0x1D0; 
        inline constexpr ::std::ptrdiff_t nameTag = 0x290; 
        inline constexpr ::std::ptrdiff_t neckBone = 0x98; 
        inline constexpr ::std::ptrdiff_t newVelocity = 0x23C; 
        inline constexpr ::std::ptrdiff_t overrideSkinSeed = 0x1E8; 
        inline constexpr ::std::ptrdiff_t position = 0x218; 
        inline constexpr ::std::ptrdiff_t preserveBones = 0x314; 
        inline constexpr ::std::ptrdiff_t rightFootBone = 0xC8; 
        inline constexpr ::std::ptrdiff_t rightFootTargetPosition = 0x128; 
        inline constexpr ::std::ptrdiff_t rightFootTargetRotation = 0x134; 
        inline constexpr ::std::ptrdiff_t rightHandPropBone = 0xD8; 
        inline constexpr ::std::ptrdiff_t rightHandTarget = 0xE0; 
        inline constexpr ::std::ptrdiff_t rightHandTargetPosition = 0x108; 
        inline constexpr ::std::ptrdiff_t rightHandTargetRotation = 0x114; 
        inline constexpr ::std::ptrdiff_t rotation = 0x248; 
        inline constexpr ::std::ptrdiff_t showSash = 0x1D8; 
        inline constexpr ::std::ptrdiff_t skinColor = 0x1BC; 
        inline constexpr ::std::ptrdiff_t skinNumber = 0x1C0; 
        inline constexpr ::std::ptrdiff_t skinType = 0x1CC; 
        inline constexpr ::std::ptrdiff_t smoothLeftFootIK = 0x268; 
        inline constexpr ::std::ptrdiff_t smoothLookDir = 0x30; 
        inline constexpr ::std::ptrdiff_t smoothRightFootIK = 0x274; 
        inline constexpr ::std::ptrdiff_t speedOverride = 0x230; 
        inline constexpr ::std::ptrdiff_t steeringTargetDegrees = 0x124; 
        inline constexpr ::std::ptrdiff_t subsurfaceProfile = 0x1B0; 
        inline constexpr ::std::ptrdiff_t tempPoseType = 0x1DC; 
        inline constexpr ::std::ptrdiff_t timeInArmsMode = 0x70; 
        inline constexpr ::std::ptrdiff_t timeSinceLeftFootTest = 0x328; 
        inline constexpr ::std::ptrdiff_t timeSinceReactionStart = 0x324; 
        inline constexpr ::std::ptrdiff_t timeSinceRightFootTest = 0x344; 
        inline constexpr ::std::ptrdiff_t underwearSkin = 0x1E0; 
        inline constexpr ::std::ptrdiff_t velocity = 0x224; 
        inline constexpr ::std::ptrdiff_t visible = 0x288; 
        inline constexpr ::std::ptrdiff_t voiceVolume = 0x1B8; 
        inline constexpr ::std::ptrdiff_t wasCrawling = 0x308; 
        inline constexpr ::std::ptrdiff_t wasMountedRightAim = 0x2F4; 
    } // namespace PlayerModel
} // namespace blazedumper
