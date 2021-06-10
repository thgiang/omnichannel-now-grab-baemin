using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BGN.Baemin
{
    public partial class BaeminHistoryStruct
    {
        [JsonProperty("docs")]
        public Doc[] Docs { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("pages")]
        public long Pages { get; set; }
    }

    public partial class Doc
    {
        [JsonProperty("coupon")]
        public Coupon Coupon { get; set; }

        [JsonProperty("payment")]
        public Payment Payment { get; set; }

        [JsonProperty("discounts")]
        public Discounts Discounts { get; set; }

        [JsonProperty("isPartner")]
        public bool IsPartner { get; set; }

        [JsonProperty("canAcceptOrder")]
        public bool CanAcceptOrder { get; set; }

        [JsonProperty("allowCashlessTransaction")]
        public bool AllowCashlessTransaction { get; set; }

        [JsonProperty("deliveryType")]
        public string DeliveryType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("merchantId")]
        public string MerchantId { get; set; }

        [JsonProperty("dishes")]
        public Dish[] Dishes { get; set; }

        [JsonProperty("toAddress")]
        public string ToAddress { get; set; }

        [JsonProperty("toAddressDetail")]
        public string ToAddressDetail { get; set; }

        [JsonProperty("toPhone")]
        public string ToPhone { get; set; }

        [JsonProperty("csId")]
        public string CsId { get; set; }

        [JsonProperty("toName")]
        public string ToName { get; set; }

        [JsonProperty("fromName")]
        public string FromName { get; set; }

        [JsonProperty("fromPhone")]
        public string FromPhone { get; set; }

        [JsonProperty("fromAddress")]
        public string FromAddress { get; set; }

        [JsonProperty("fromImageUrl")]
        public Uri FromImageUrl { get; set; }

        [JsonProperty("originalDishTotalPrice")]
        public long OriginalDishTotalPrice { get; set; }

        [JsonProperty("dishTotalPrice")]
        public long DishTotalPrice { get; set; }

        [JsonProperty("discountedTotalPrice")]
        public long DiscountedTotalPrice { get; set; }

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("readyToPickupAt")]
        public DateTimeOffset ReadyToPickupAt { get; set; }

        [JsonProperty("assignedAt")]
        public DateTimeOffset AssignedAt { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("deliverySurcharge")]
        public long DeliverySurcharge { get; set; }

        [JsonProperty("serviceSurcharge")]
        public object[] ServiceSurcharge { get; set; }

        [JsonProperty("canUserCancel")]
        public bool CanUserCancel { get; set; }

        [JsonProperty("canMerchantCancel")]
        public bool CanMerchantCancel { get; set; }

        [JsonProperty("canAgentCancel")]
        public bool CanAgentCancel { get; set; }

        [JsonProperty("deliveryFeeDetails")]
        public DeliveryFeeDetail[] DeliveryFeeDetails { get; set; }

        [JsonProperty("orderReview")]
        public OrderReview OrderReview { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public partial class Coupon
    {
        [JsonProperty("code")]
        public string[] Code { get; set; }

        [JsonProperty("redemptionId")]
        public string RedemptionId { get; set; }
    }

    public partial class DeliveryFeeDetail
    {
        [JsonProperty("amount")]
        public object Amount { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Discounts
    {
        [JsonProperty("totalAmount")]
        public long TotalAmount { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("targetValues")]
        public TargetValue[] TargetValues { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("methodType")]
        public string MethodType { get; set; }

        [JsonProperty("methodValue")]
        public long MethodValue { get; set; }

        [JsonProperty("targetType")]
        public string TargetType { get; set; }
    }

    public partial class TargetValue
    {
        [JsonProperty("originalPrice")]
        public long OriginalPrice { get; set; }

        [JsonProperty("discountedPrice")]
        public long DiscountedPrice { get; set; }

        [JsonProperty("discountedAmount")]
        public long DiscountedAmount { get; set; }
    }

    public partial class Dish
    {
        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonProperty("options")]
        public object[] Options { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("memo")]
        public string Memo { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("dishId")]
        public string DishDishId { get; set; }

        [JsonProperty("uniqueId")]
        public string UniqueId { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("imageUrl")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("originalPrice")]
        public long OriginalPrice { get; set; }

        [JsonProperty("section")]
        public string Section { get; set; }

        [JsonProperty("id")]
        public string DishId { get; set; }
    }

    public partial class OrderReview
    {
        [JsonProperty("canReviewRider")]
        public bool CanReviewRider { get; set; }

        [JsonProperty("canReviewMerchant")]
        public bool CanReviewMerchant { get; set; }
    }

    public partial class Payment
    {
        [JsonProperty("transaction")]
        public Transaction Transaction { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }
    }

    public partial class Transaction
    {
        [JsonProperty("paymentTransactionId")]
        public string PaymentTransactionId { get; set; }

        [JsonProperty("trxId")]
        public string TrxId { get; set; }
    }
}
