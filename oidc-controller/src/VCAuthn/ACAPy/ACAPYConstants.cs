namespace VCAuthn.ACAPY
{
    public static class ACAPYConstants
    {
        public const string ApiKeyHeader = "x-api-key";

        public const string WalletDidPublicUri = "/wallet/did/public";

        public const string PresentProofCreateRequest = "/present-proof/create-request";

        public const string GetPresentationRecord = "/present-proof/records";

        public const string VerifiedPresentationState = "verified";

        public const string PresentationsTopic = "present_proof";
    }
}