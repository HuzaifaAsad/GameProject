// using System;
// using System.Collections;
// using System.Collections.Generic;
// using Unity.VisualScripting;
// using UnityEngine;
// using UnityEngine.Purchasing;

// public class IAP : MonoBehaviour, IStoreListener
// {
//     // Start is called before the first frame update
//     private static IStoreController storeController;
//     public static string COIN_PRDOUCT_ID = "coin_100";
//     public static string NO_ADS_ID = "no_ads";
//     void Start()
//     {
//         InitializePurchasing();
//     }

//     // Update is called once per frame
//     void Update()
//     {

//     }
//     public void InitializePurchasing()
//     {
//         var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());
//         builder.AddProduct(COIN_PRDOUCT_ID, ProductType.Consumable);
//         builder.AddProduct(NO_ADS_ID, ProductType.NonConsumable);
//         UnityPurchasing.Initialize(this, builder);
//     }
//     public void BuyCoins()
//     {
//         storeController.InitiatePurchase(COIN_PRDOUCT_ID);
//     }
//     public void NoAds()
//     {
//         storeController.InitiatePurchase(NO_ADS_ID);
//     }
//     public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
//     {
//         storeController = controller;
//     }
//     public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
//     {
//         if (args.purchasedProduct.definition.id == COIN_PRDOUCT_ID)
//         {
//             Debug.Log("Coins Bought");
//         }
//         else if (args.purchasedProduct.definition.id == NO_ADS_ID)
//         {
//             Debug.Log("No Ads Now");

//         }
//         return PurchaseProcessingResult.Complete;
//     }
//     // public void OnPurchaseFailed(Product product,PurchaseFailureReason reason)
//     // {
//     //     Debug.Log("Reason of Failure" + reason);
//     // }
// }
