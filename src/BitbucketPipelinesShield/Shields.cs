﻿namespace BitbucketPipelinesShield
{
    using Nancy;
    public static class Shields
    {
        private const string SvgContentType = "image/svg+xml";
        private static readonly byte[] BitbucketPipelinesShield = { 0x3c, 0x73, 0x76, 0x67, 0x20, 0x78, 0x6d, 0x6c, 0x6e, 0x73, 0x3d, 0x22, 0x68, 0x74, 0x74, 0x70, 0x3a, 0x2f, 0x2f, 0x77, 0x77, 0x77, 0x2e, 0x77, 0x33, 0x2e, 0x6f, 0x72, 0x67, 0x2f, 0x32, 0x30, 0x30, 0x30, 0x2f, 0x73, 0x76, 0x67, 0x22, 0x20, 0x77, 0x69, 0x64, 0x74, 0x68, 0x3d, 0x22, 0x31, 0x35, 0x38, 0x22, 0x20, 0x68, 0x65, 0x69, 0x67, 0x68, 0x74, 0x3d, 0x22, 0x32, 0x30, 0x22, 0x3e, 0x3c, 0x6c, 0x69, 0x6e, 0x65, 0x61, 0x72, 0x47, 0x72, 0x61, 0x64, 0x69, 0x65, 0x6e, 0x74, 0x20, 0x69, 0x64, 0x3d, 0x22, 0x62, 0x22, 0x20, 0x78, 0x32, 0x3d, 0x22, 0x30, 0x22, 0x20, 0x79, 0x32, 0x3d, 0x22, 0x31, 0x30, 0x30, 0x25, 0x22, 0x3e, 0x3c, 0x73, 0x74, 0x6f, 0x70, 0x20, 0x6f, 0x66, 0x66, 0x73, 0x65, 0x74, 0x3d, 0x22, 0x30, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x63, 0x6f, 0x6c, 0x6f, 0x72, 0x3d, 0x22, 0x23, 0x62, 0x62, 0x62, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x31, 0x22, 0x2f, 0x3e, 0x3c, 0x73, 0x74, 0x6f, 0x70, 0x20, 0x6f, 0x66, 0x66, 0x73, 0x65, 0x74, 0x3d, 0x22, 0x31, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x31, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x6c, 0x69, 0x6e, 0x65, 0x61, 0x72, 0x47, 0x72, 0x61, 0x64, 0x69, 0x65, 0x6e, 0x74, 0x3e, 0x3c, 0x6d, 0x61, 0x73, 0x6b, 0x20, 0x69, 0x64, 0x3d, 0x22, 0x61, 0x22, 0x3e, 0x3c, 0x72, 0x65, 0x63, 0x74, 0x20, 0x77, 0x69, 0x64, 0x74, 0x68, 0x3d, 0x22, 0x31, 0x35, 0x38, 0x22, 0x20, 0x68, 0x65, 0x69, 0x67, 0x68, 0x74, 0x3d, 0x22, 0x32, 0x30, 0x22, 0x20, 0x72, 0x78, 0x3d, 0x22, 0x33, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x66, 0x66, 0x66, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x6d, 0x61, 0x73, 0x6b, 0x3e, 0x3c, 0x67, 0x20, 0x6d, 0x61, 0x73, 0x6b, 0x3d, 0x22, 0x75, 0x72, 0x6c, 0x28, 0x23, 0x61, 0x29, 0x22, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x35, 0x35, 0x35, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x30, 0x20, 0x30, 0x68, 0x31, 0x31, 0x35, 0x76, 0x32, 0x30, 0x48, 0x30, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x34, 0x63, 0x31, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x31, 0x31, 0x35, 0x20, 0x30, 0x68, 0x34, 0x33, 0x76, 0x32, 0x30, 0x68, 0x2d, 0x34, 0x33, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x75, 0x72, 0x6c, 0x28, 0x23, 0x62, 0x29, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x30, 0x20, 0x30, 0x68, 0x31, 0x35, 0x38, 0x76, 0x32, 0x30, 0x48, 0x30, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x67, 0x3e, 0x3c, 0x67, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x66, 0x66, 0x66, 0x22, 0x20, 0x74, 0x65, 0x78, 0x74, 0x2d, 0x61, 0x6e, 0x63, 0x68, 0x6f, 0x72, 0x3d, 0x22, 0x6d, 0x69, 0x64, 0x64, 0x6c, 0x65, 0x22, 0x20, 0x66, 0x6f, 0x6e, 0x74, 0x2d, 0x66, 0x61, 0x6d, 0x69, 0x6c, 0x79, 0x3d, 0x22, 0x44, 0x65, 0x6a, 0x61, 0x56, 0x75, 0x20, 0x53, 0x61, 0x6e, 0x73, 0x2c, 0x56, 0x65, 0x72, 0x64, 0x61, 0x6e, 0x61, 0x2c, 0x47, 0x65, 0x6e, 0x65, 0x76, 0x61, 0x2c, 0x73, 0x61, 0x6e, 0x73, 0x2d, 0x73, 0x65, 0x72, 0x69, 0x66, 0x22, 0x20, 0x66, 0x6f, 0x6e, 0x74, 0x2d, 0x73, 0x69, 0x7a, 0x65, 0x3d, 0x22, 0x31, 0x31, 0x22, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x35, 0x37, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x35, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x30, 0x31, 0x30, 0x31, 0x30, 0x31, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x33, 0x22, 0x3e, 0x42, 0x69, 0x74, 0x62, 0x75, 0x63, 0x6b, 0x65, 0x74, 0x20, 0x50, 0x69, 0x70, 0x65, 0x6c, 0x69, 0x6e, 0x65, 0x73, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x35, 0x37, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x34, 0x22, 0x3e, 0x42, 0x69, 0x74, 0x62, 0x75, 0x63, 0x6b, 0x65, 0x74, 0x20, 0x50, 0x69, 0x70, 0x65, 0x6c, 0x69, 0x6e, 0x65, 0x73, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x31, 0x33, 0x35, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x35, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x30, 0x31, 0x30, 0x31, 0x30, 0x31, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x33, 0x22, 0x3e, 0x53, 0x68, 0x69, 0x65, 0x6c, 0x64, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x31, 0x33, 0x35, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x34, 0x22, 0x3e, 0x53, 0x68, 0x69, 0x65, 0x6c, 0x64, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x2f, 0x67, 0x3e, 0x3c, 0x2f, 0x73, 0x76, 0x67, 0x3e };
        private const int BitbucketPipelinesShieldLength = 770;
        public static Response BitbucketPipelinesShieldResponse { get; } =   new Response {
                                                                            ContentType = SvgContentType,
                                                                            Contents = stream => stream.Write(BitbucketPipelinesShield, 0, BitbucketPipelinesShieldLength),
                                                                            Headers =   { 
                                                                                            { "Content-Disposition", "inline;filename=BitbucketPipelinesShield.svg" },
                                                                                            { "Pragma", "no-cache"},
                                                                                            {"Cache-Control", "no-store, no-cache, must-revalidate, pre-check=0, post-check=0, max-age=0"},
                                                                                            {"Expires", "-1"}
                                                                                        }
                                                                        }; 
        private static readonly byte[] BuildPassing = { 0x3c, 0x73, 0x76, 0x67, 0x20, 0x78, 0x6d, 0x6c, 0x6e, 0x73, 0x3d, 0x22, 0x68, 0x74, 0x74, 0x70, 0x3a, 0x2f, 0x2f, 0x77, 0x77, 0x77, 0x2e, 0x77, 0x33, 0x2e, 0x6f, 0x72, 0x67, 0x2f, 0x32, 0x30, 0x30, 0x30, 0x2f, 0x73, 0x76, 0x67, 0x22, 0x20, 0x77, 0x69, 0x64, 0x74, 0x68, 0x3d, 0x22, 0x38, 0x38, 0x22, 0x20, 0x68, 0x65, 0x69, 0x67, 0x68, 0x74, 0x3d, 0x22, 0x32, 0x30, 0x22, 0x3e, 0x3c, 0x6c, 0x69, 0x6e, 0x65, 0x61, 0x72, 0x47, 0x72, 0x61, 0x64, 0x69, 0x65, 0x6e, 0x74, 0x20, 0x69, 0x64, 0x3d, 0x22, 0x62, 0x22, 0x20, 0x78, 0x32, 0x3d, 0x22, 0x30, 0x22, 0x20, 0x79, 0x32, 0x3d, 0x22, 0x31, 0x30, 0x30, 0x25, 0x22, 0x3e, 0x3c, 0x73, 0x74, 0x6f, 0x70, 0x20, 0x6f, 0x66, 0x66, 0x73, 0x65, 0x74, 0x3d, 0x22, 0x30, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x63, 0x6f, 0x6c, 0x6f, 0x72, 0x3d, 0x22, 0x23, 0x62, 0x62, 0x62, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x31, 0x22, 0x2f, 0x3e, 0x3c, 0x73, 0x74, 0x6f, 0x70, 0x20, 0x6f, 0x66, 0x66, 0x73, 0x65, 0x74, 0x3d, 0x22, 0x31, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x31, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x6c, 0x69, 0x6e, 0x65, 0x61, 0x72, 0x47, 0x72, 0x61, 0x64, 0x69, 0x65, 0x6e, 0x74, 0x3e, 0x3c, 0x6d, 0x61, 0x73, 0x6b, 0x20, 0x69, 0x64, 0x3d, 0x22, 0x61, 0x22, 0x3e, 0x3c, 0x72, 0x65, 0x63, 0x74, 0x20, 0x77, 0x69, 0x64, 0x74, 0x68, 0x3d, 0x22, 0x38, 0x38, 0x22, 0x20, 0x68, 0x65, 0x69, 0x67, 0x68, 0x74, 0x3d, 0x22, 0x32, 0x30, 0x22, 0x20, 0x72, 0x78, 0x3d, 0x22, 0x33, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x66, 0x66, 0x66, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x6d, 0x61, 0x73, 0x6b, 0x3e, 0x3c, 0x67, 0x20, 0x6d, 0x61, 0x73, 0x6b, 0x3d, 0x22, 0x75, 0x72, 0x6c, 0x28, 0x23, 0x61, 0x29, 0x22, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x35, 0x35, 0x35, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x30, 0x20, 0x30, 0x68, 0x33, 0x37, 0x76, 0x32, 0x30, 0x48, 0x30, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x34, 0x63, 0x31, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x33, 0x37, 0x20, 0x30, 0x68, 0x35, 0x31, 0x76, 0x32, 0x30, 0x48, 0x33, 0x37, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x75, 0x72, 0x6c, 0x28, 0x23, 0x62, 0x29, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x30, 0x20, 0x30, 0x68, 0x38, 0x38, 0x76, 0x32, 0x30, 0x48, 0x30, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x67, 0x3e, 0x3c, 0x67, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x66, 0x66, 0x66, 0x22, 0x20, 0x74, 0x65, 0x78, 0x74, 0x2d, 0x61, 0x6e, 0x63, 0x68, 0x6f, 0x72, 0x3d, 0x22, 0x6d, 0x69, 0x64, 0x64, 0x6c, 0x65, 0x22, 0x20, 0x66, 0x6f, 0x6e, 0x74, 0x2d, 0x66, 0x61, 0x6d, 0x69, 0x6c, 0x79, 0x3d, 0x22, 0x44, 0x65, 0x6a, 0x61, 0x56, 0x75, 0x20, 0x53, 0x61, 0x6e, 0x73, 0x2c, 0x56, 0x65, 0x72, 0x64, 0x61, 0x6e, 0x61, 0x2c, 0x47, 0x65, 0x6e, 0x65, 0x76, 0x61, 0x2c, 0x73, 0x61, 0x6e, 0x73, 0x2d, 0x73, 0x65, 0x72, 0x69, 0x66, 0x22, 0x20, 0x66, 0x6f, 0x6e, 0x74, 0x2d, 0x73, 0x69, 0x7a, 0x65, 0x3d, 0x22, 0x31, 0x31, 0x22, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x31, 0x38, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x35, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x30, 0x31, 0x30, 0x31, 0x30, 0x31, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x33, 0x22, 0x3e, 0x62, 0x75, 0x69, 0x6c, 0x64, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x31, 0x38, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x34, 0x22, 0x3e, 0x62, 0x75, 0x69, 0x6c, 0x64, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x36, 0x31, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x35, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x30, 0x31, 0x30, 0x31, 0x30, 0x31, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x33, 0x22, 0x3e, 0x70, 0x61, 0x73, 0x73, 0x69, 0x6e, 0x67, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x36, 0x31, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x34, 0x22, 0x3e, 0x70, 0x61, 0x73, 0x73, 0x69, 0x6e, 0x67, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x2f, 0x67, 0x3e, 0x3c, 0x2f, 0x73, 0x76, 0x67, 0x3e };
        private const int BuildPassingLength = 736;
        public static Response BuildPassingResponse { get; } =   new Response {
                                                                            ContentType = SvgContentType,
                                                                            Contents = stream => stream.Write(BuildPassing, 0, BuildPassingLength),
                                                                            Headers =   { 
                                                                                            { "Content-Disposition", "inline;filename=BuildPassing.svg" },
                                                                                            { "Pragma", "no-cache"},
                                                                                            {"Cache-Control", "no-store, no-cache, must-revalidate, pre-check=0, post-check=0, max-age=0"},
                                                                                            {"Expires", "-1"}
                                                                                        }
                                                                        }; 
        private static readonly byte[] BuildFailing = { 0x3c, 0x73, 0x76, 0x67, 0x20, 0x78, 0x6d, 0x6c, 0x6e, 0x73, 0x3d, 0x22, 0x68, 0x74, 0x74, 0x70, 0x3a, 0x2f, 0x2f, 0x77, 0x77, 0x77, 0x2e, 0x77, 0x33, 0x2e, 0x6f, 0x72, 0x67, 0x2f, 0x32, 0x30, 0x30, 0x30, 0x2f, 0x73, 0x76, 0x67, 0x22, 0x20, 0x77, 0x69, 0x64, 0x74, 0x68, 0x3d, 0x22, 0x38, 0x30, 0x22, 0x20, 0x68, 0x65, 0x69, 0x67, 0x68, 0x74, 0x3d, 0x22, 0x32, 0x30, 0x22, 0x3e, 0x3c, 0x6c, 0x69, 0x6e, 0x65, 0x61, 0x72, 0x47, 0x72, 0x61, 0x64, 0x69, 0x65, 0x6e, 0x74, 0x20, 0x69, 0x64, 0x3d, 0x22, 0x62, 0x22, 0x20, 0x78, 0x32, 0x3d, 0x22, 0x30, 0x22, 0x20, 0x79, 0x32, 0x3d, 0x22, 0x31, 0x30, 0x30, 0x25, 0x22, 0x3e, 0x3c, 0x73, 0x74, 0x6f, 0x70, 0x20, 0x6f, 0x66, 0x66, 0x73, 0x65, 0x74, 0x3d, 0x22, 0x30, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x63, 0x6f, 0x6c, 0x6f, 0x72, 0x3d, 0x22, 0x23, 0x62, 0x62, 0x62, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x31, 0x22, 0x2f, 0x3e, 0x3c, 0x73, 0x74, 0x6f, 0x70, 0x20, 0x6f, 0x66, 0x66, 0x73, 0x65, 0x74, 0x3d, 0x22, 0x31, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x31, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x6c, 0x69, 0x6e, 0x65, 0x61, 0x72, 0x47, 0x72, 0x61, 0x64, 0x69, 0x65, 0x6e, 0x74, 0x3e, 0x3c, 0x6d, 0x61, 0x73, 0x6b, 0x20, 0x69, 0x64, 0x3d, 0x22, 0x61, 0x22, 0x3e, 0x3c, 0x72, 0x65, 0x63, 0x74, 0x20, 0x77, 0x69, 0x64, 0x74, 0x68, 0x3d, 0x22, 0x38, 0x30, 0x22, 0x20, 0x68, 0x65, 0x69, 0x67, 0x68, 0x74, 0x3d, 0x22, 0x32, 0x30, 0x22, 0x20, 0x72, 0x78, 0x3d, 0x22, 0x33, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x66, 0x66, 0x66, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x6d, 0x61, 0x73, 0x6b, 0x3e, 0x3c, 0x67, 0x20, 0x6d, 0x61, 0x73, 0x6b, 0x3d, 0x22, 0x75, 0x72, 0x6c, 0x28, 0x23, 0x61, 0x29, 0x22, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x35, 0x35, 0x35, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x30, 0x20, 0x30, 0x68, 0x33, 0x37, 0x76, 0x32, 0x30, 0x48, 0x30, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x65, 0x30, 0x35, 0x64, 0x34, 0x34, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x33, 0x37, 0x20, 0x30, 0x68, 0x34, 0x33, 0x76, 0x32, 0x30, 0x48, 0x33, 0x37, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x75, 0x72, 0x6c, 0x28, 0x23, 0x62, 0x29, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x30, 0x20, 0x30, 0x68, 0x38, 0x30, 0x76, 0x32, 0x30, 0x48, 0x30, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x67, 0x3e, 0x3c, 0x67, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x66, 0x66, 0x66, 0x22, 0x20, 0x74, 0x65, 0x78, 0x74, 0x2d, 0x61, 0x6e, 0x63, 0x68, 0x6f, 0x72, 0x3d, 0x22, 0x6d, 0x69, 0x64, 0x64, 0x6c, 0x65, 0x22, 0x20, 0x66, 0x6f, 0x6e, 0x74, 0x2d, 0x66, 0x61, 0x6d, 0x69, 0x6c, 0x79, 0x3d, 0x22, 0x44, 0x65, 0x6a, 0x61, 0x56, 0x75, 0x20, 0x53, 0x61, 0x6e, 0x73, 0x2c, 0x56, 0x65, 0x72, 0x64, 0x61, 0x6e, 0x61, 0x2c, 0x47, 0x65, 0x6e, 0x65, 0x76, 0x61, 0x2c, 0x73, 0x61, 0x6e, 0x73, 0x2d, 0x73, 0x65, 0x72, 0x69, 0x66, 0x22, 0x20, 0x66, 0x6f, 0x6e, 0x74, 0x2d, 0x73, 0x69, 0x7a, 0x65, 0x3d, 0x22, 0x31, 0x31, 0x22, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x31, 0x38, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x35, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x30, 0x31, 0x30, 0x31, 0x30, 0x31, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x33, 0x22, 0x3e, 0x62, 0x75, 0x69, 0x6c, 0x64, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x31, 0x38, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x34, 0x22, 0x3e, 0x62, 0x75, 0x69, 0x6c, 0x64, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x35, 0x37, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x35, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x30, 0x31, 0x30, 0x31, 0x30, 0x31, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x33, 0x22, 0x3e, 0x66, 0x61, 0x69, 0x6c, 0x69, 0x6e, 0x67, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x35, 0x37, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x34, 0x22, 0x3e, 0x66, 0x61, 0x69, 0x6c, 0x69, 0x6e, 0x67, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x2f, 0x67, 0x3e, 0x3c, 0x2f, 0x73, 0x76, 0x67, 0x3e };
        private const int BuildFailingLength = 739;
        public static Response BuildFailingResponse { get; } =   new Response {
                                                                            ContentType = SvgContentType,
                                                                            Contents = stream => stream.Write(BuildFailing, 0, BuildFailingLength),
                                                                            Headers =   { 
                                                                                            { "Content-Disposition", "inline;filename=BuildFailing.svg" },
                                                                                            { "Pragma", "no-cache"},
                                                                                            {"Cache-Control", "no-store, no-cache, must-revalidate, pre-check=0, post-check=0, max-age=0"},
                                                                                            {"Expires", "-1"}
                                                                                        }
                                                                        }; 
        private static readonly byte[] BuildRunning = { 0x3c, 0x73, 0x76, 0x67, 0x20, 0x78, 0x6d, 0x6c, 0x6e, 0x73, 0x3d, 0x22, 0x68, 0x74, 0x74, 0x70, 0x3a, 0x2f, 0x2f, 0x77, 0x77, 0x77, 0x2e, 0x77, 0x33, 0x2e, 0x6f, 0x72, 0x67, 0x2f, 0x32, 0x30, 0x30, 0x30, 0x2f, 0x73, 0x76, 0x67, 0x22, 0x20, 0x77, 0x69, 0x64, 0x74, 0x68, 0x3d, 0x22, 0x39, 0x30, 0x22, 0x20, 0x68, 0x65, 0x69, 0x67, 0x68, 0x74, 0x3d, 0x22, 0x32, 0x30, 0x22, 0x3e, 0x3c, 0x6c, 0x69, 0x6e, 0x65, 0x61, 0x72, 0x47, 0x72, 0x61, 0x64, 0x69, 0x65, 0x6e, 0x74, 0x20, 0x69, 0x64, 0x3d, 0x22, 0x62, 0x22, 0x20, 0x78, 0x32, 0x3d, 0x22, 0x30, 0x22, 0x20, 0x79, 0x32, 0x3d, 0x22, 0x31, 0x30, 0x30, 0x25, 0x22, 0x3e, 0x3c, 0x73, 0x74, 0x6f, 0x70, 0x20, 0x6f, 0x66, 0x66, 0x73, 0x65, 0x74, 0x3d, 0x22, 0x30, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x63, 0x6f, 0x6c, 0x6f, 0x72, 0x3d, 0x22, 0x23, 0x62, 0x62, 0x62, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x31, 0x22, 0x2f, 0x3e, 0x3c, 0x73, 0x74, 0x6f, 0x70, 0x20, 0x6f, 0x66, 0x66, 0x73, 0x65, 0x74, 0x3d, 0x22, 0x31, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x31, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x6c, 0x69, 0x6e, 0x65, 0x61, 0x72, 0x47, 0x72, 0x61, 0x64, 0x69, 0x65, 0x6e, 0x74, 0x3e, 0x3c, 0x6d, 0x61, 0x73, 0x6b, 0x20, 0x69, 0x64, 0x3d, 0x22, 0x61, 0x22, 0x3e, 0x3c, 0x72, 0x65, 0x63, 0x74, 0x20, 0x77, 0x69, 0x64, 0x74, 0x68, 0x3d, 0x22, 0x39, 0x30, 0x22, 0x20, 0x68, 0x65, 0x69, 0x67, 0x68, 0x74, 0x3d, 0x22, 0x32, 0x30, 0x22, 0x20, 0x72, 0x78, 0x3d, 0x22, 0x33, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x66, 0x66, 0x66, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x6d, 0x61, 0x73, 0x6b, 0x3e, 0x3c, 0x67, 0x20, 0x6d, 0x61, 0x73, 0x6b, 0x3d, 0x22, 0x75, 0x72, 0x6c, 0x28, 0x23, 0x61, 0x29, 0x22, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x35, 0x35, 0x35, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x30, 0x20, 0x30, 0x68, 0x33, 0x37, 0x76, 0x32, 0x30, 0x48, 0x30, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x39, 0x66, 0x39, 0x66, 0x39, 0x66, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x33, 0x37, 0x20, 0x30, 0x68, 0x35, 0x33, 0x76, 0x32, 0x30, 0x48, 0x33, 0x37, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x75, 0x72, 0x6c, 0x28, 0x23, 0x62, 0x29, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x30, 0x20, 0x30, 0x68, 0x39, 0x30, 0x76, 0x32, 0x30, 0x48, 0x30, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x67, 0x3e, 0x3c, 0x67, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x66, 0x66, 0x66, 0x22, 0x20, 0x74, 0x65, 0x78, 0x74, 0x2d, 0x61, 0x6e, 0x63, 0x68, 0x6f, 0x72, 0x3d, 0x22, 0x6d, 0x69, 0x64, 0x64, 0x6c, 0x65, 0x22, 0x20, 0x66, 0x6f, 0x6e, 0x74, 0x2d, 0x66, 0x61, 0x6d, 0x69, 0x6c, 0x79, 0x3d, 0x22, 0x44, 0x65, 0x6a, 0x61, 0x56, 0x75, 0x20, 0x53, 0x61, 0x6e, 0x73, 0x2c, 0x56, 0x65, 0x72, 0x64, 0x61, 0x6e, 0x61, 0x2c, 0x47, 0x65, 0x6e, 0x65, 0x76, 0x61, 0x2c, 0x73, 0x61, 0x6e, 0x73, 0x2d, 0x73, 0x65, 0x72, 0x69, 0x66, 0x22, 0x20, 0x66, 0x6f, 0x6e, 0x74, 0x2d, 0x73, 0x69, 0x7a, 0x65, 0x3d, 0x22, 0x31, 0x31, 0x22, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x31, 0x38, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x35, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x30, 0x31, 0x30, 0x31, 0x30, 0x31, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x33, 0x22, 0x3e, 0x62, 0x75, 0x69, 0x6c, 0x64, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x31, 0x38, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x34, 0x22, 0x3e, 0x62, 0x75, 0x69, 0x6c, 0x64, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x36, 0x32, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x35, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x30, 0x31, 0x30, 0x31, 0x30, 0x31, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x33, 0x22, 0x3e, 0x72, 0x75, 0x6e, 0x6e, 0x69, 0x6e, 0x67, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x36, 0x32, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x34, 0x22, 0x3e, 0x72, 0x75, 0x6e, 0x6e, 0x69, 0x6e, 0x67, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x2f, 0x67, 0x3e, 0x3c, 0x2f, 0x73, 0x76, 0x67, 0x3e };
        private const int BuildRunningLength = 739;
        public static Response BuildRunningResponse { get; } =   new Response {
                                                                            ContentType = SvgContentType,
                                                                            Contents = stream => stream.Write(BuildRunning, 0, BuildRunningLength),
                                                                            Headers =   { 
                                                                                            { "Content-Disposition", "inline;filename=BuildRunning.svg" },
                                                                                            { "Pragma", "no-cache"},
                                                                                            {"Cache-Control", "no-store, no-cache, must-revalidate, pre-check=0, post-check=0, max-age=0"},
                                                                                            {"Expires", "-1"}
                                                                                        }
                                                                        }; 
        private static readonly byte[] BuildUnresponsive = { 0x3c, 0x73, 0x76, 0x67, 0x20, 0x78, 0x6d, 0x6c, 0x6e, 0x73, 0x3d, 0x22, 0x68, 0x74, 0x74, 0x70, 0x3a, 0x2f, 0x2f, 0x77, 0x77, 0x77, 0x2e, 0x77, 0x33, 0x2e, 0x6f, 0x72, 0x67, 0x2f, 0x32, 0x30, 0x30, 0x30, 0x2f, 0x73, 0x76, 0x67, 0x22, 0x20, 0x77, 0x69, 0x64, 0x74, 0x68, 0x3d, 0x22, 0x31, 0x32, 0x30, 0x22, 0x20, 0x68, 0x65, 0x69, 0x67, 0x68, 0x74, 0x3d, 0x22, 0x32, 0x30, 0x22, 0x3e, 0x3c, 0x6c, 0x69, 0x6e, 0x65, 0x61, 0x72, 0x47, 0x72, 0x61, 0x64, 0x69, 0x65, 0x6e, 0x74, 0x20, 0x69, 0x64, 0x3d, 0x22, 0x62, 0x22, 0x20, 0x78, 0x32, 0x3d, 0x22, 0x30, 0x22, 0x20, 0x79, 0x32, 0x3d, 0x22, 0x31, 0x30, 0x30, 0x25, 0x22, 0x3e, 0x3c, 0x73, 0x74, 0x6f, 0x70, 0x20, 0x6f, 0x66, 0x66, 0x73, 0x65, 0x74, 0x3d, 0x22, 0x30, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x63, 0x6f, 0x6c, 0x6f, 0x72, 0x3d, 0x22, 0x23, 0x62, 0x62, 0x62, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x31, 0x22, 0x2f, 0x3e, 0x3c, 0x73, 0x74, 0x6f, 0x70, 0x20, 0x6f, 0x66, 0x66, 0x73, 0x65, 0x74, 0x3d, 0x22, 0x31, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x31, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x6c, 0x69, 0x6e, 0x65, 0x61, 0x72, 0x47, 0x72, 0x61, 0x64, 0x69, 0x65, 0x6e, 0x74, 0x3e, 0x3c, 0x6d, 0x61, 0x73, 0x6b, 0x20, 0x69, 0x64, 0x3d, 0x22, 0x61, 0x22, 0x3e, 0x3c, 0x72, 0x65, 0x63, 0x74, 0x20, 0x77, 0x69, 0x64, 0x74, 0x68, 0x3d, 0x22, 0x31, 0x32, 0x30, 0x22, 0x20, 0x68, 0x65, 0x69, 0x67, 0x68, 0x74, 0x3d, 0x22, 0x32, 0x30, 0x22, 0x20, 0x72, 0x78, 0x3d, 0x22, 0x33, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x66, 0x66, 0x66, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x6d, 0x61, 0x73, 0x6b, 0x3e, 0x3c, 0x67, 0x20, 0x6d, 0x61, 0x73, 0x6b, 0x3d, 0x22, 0x75, 0x72, 0x6c, 0x28, 0x23, 0x61, 0x29, 0x22, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x35, 0x35, 0x35, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x30, 0x20, 0x30, 0x68, 0x33, 0x37, 0x76, 0x32, 0x30, 0x48, 0x30, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x39, 0x66, 0x39, 0x66, 0x39, 0x66, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x33, 0x37, 0x20, 0x30, 0x68, 0x38, 0x33, 0x76, 0x32, 0x30, 0x48, 0x33, 0x37, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x75, 0x72, 0x6c, 0x28, 0x23, 0x62, 0x29, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x30, 0x20, 0x30, 0x68, 0x31, 0x32, 0x30, 0x76, 0x32, 0x30, 0x48, 0x30, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x67, 0x3e, 0x3c, 0x67, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x66, 0x66, 0x66, 0x22, 0x20, 0x74, 0x65, 0x78, 0x74, 0x2d, 0x61, 0x6e, 0x63, 0x68, 0x6f, 0x72, 0x3d, 0x22, 0x6d, 0x69, 0x64, 0x64, 0x6c, 0x65, 0x22, 0x20, 0x66, 0x6f, 0x6e, 0x74, 0x2d, 0x66, 0x61, 0x6d, 0x69, 0x6c, 0x79, 0x3d, 0x22, 0x44, 0x65, 0x6a, 0x61, 0x56, 0x75, 0x20, 0x53, 0x61, 0x6e, 0x73, 0x2c, 0x56, 0x65, 0x72, 0x64, 0x61, 0x6e, 0x61, 0x2c, 0x47, 0x65, 0x6e, 0x65, 0x76, 0x61, 0x2c, 0x73, 0x61, 0x6e, 0x73, 0x2d, 0x73, 0x65, 0x72, 0x69, 0x66, 0x22, 0x20, 0x66, 0x6f, 0x6e, 0x74, 0x2d, 0x73, 0x69, 0x7a, 0x65, 0x3d, 0x22, 0x31, 0x31, 0x22, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x31, 0x38, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x35, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x30, 0x31, 0x30, 0x31, 0x30, 0x31, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x33, 0x22, 0x3e, 0x62, 0x75, 0x69, 0x6c, 0x64, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x31, 0x38, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x34, 0x22, 0x3e, 0x62, 0x75, 0x69, 0x6c, 0x64, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x37, 0x37, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x35, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x30, 0x31, 0x30, 0x31, 0x30, 0x31, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x33, 0x22, 0x3e, 0x75, 0x6e, 0x72, 0x65, 0x73, 0x70, 0x6f, 0x6e, 0x73, 0x69, 0x76, 0x65, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x37, 0x37, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x34, 0x22, 0x3e, 0x75, 0x6e, 0x72, 0x65, 0x73, 0x70, 0x6f, 0x6e, 0x73, 0x69, 0x76, 0x65, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x2f, 0x67, 0x3e, 0x3c, 0x2f, 0x73, 0x76, 0x67, 0x3e };
        private const int BuildUnresponsiveLength = 752;
        public static Response BuildUnresponsiveResponse { get; } =   new Response {
                                                                            ContentType = SvgContentType,
                                                                            Contents = stream => stream.Write(BuildUnresponsive, 0, BuildUnresponsiveLength),
                                                                            Headers =   { 
                                                                                            { "Content-Disposition", "inline;filename=BuildUnresponsive.svg" },
                                                                                            { "Pragma", "no-cache"},
                                                                                            {"Cache-Control", "no-store, no-cache, must-revalidate, pre-check=0, post-check=0, max-age=0"},
                                                                                            {"Expires", "-1"}
                                                                                        }
                                                                        }; 
        private static readonly byte[] BuildUnknown = { 0x3c, 0x73, 0x76, 0x67, 0x20, 0x78, 0x6d, 0x6c, 0x6e, 0x73, 0x3d, 0x22, 0x68, 0x74, 0x74, 0x70, 0x3a, 0x2f, 0x2f, 0x77, 0x77, 0x77, 0x2e, 0x77, 0x33, 0x2e, 0x6f, 0x72, 0x67, 0x2f, 0x32, 0x30, 0x30, 0x30, 0x2f, 0x73, 0x76, 0x67, 0x22, 0x20, 0x77, 0x69, 0x64, 0x74, 0x68, 0x3d, 0x22, 0x39, 0x38, 0x22, 0x20, 0x68, 0x65, 0x69, 0x67, 0x68, 0x74, 0x3d, 0x22, 0x32, 0x30, 0x22, 0x3e, 0x3c, 0x6c, 0x69, 0x6e, 0x65, 0x61, 0x72, 0x47, 0x72, 0x61, 0x64, 0x69, 0x65, 0x6e, 0x74, 0x20, 0x69, 0x64, 0x3d, 0x22, 0x62, 0x22, 0x20, 0x78, 0x32, 0x3d, 0x22, 0x30, 0x22, 0x20, 0x79, 0x32, 0x3d, 0x22, 0x31, 0x30, 0x30, 0x25, 0x22, 0x3e, 0x3c, 0x73, 0x74, 0x6f, 0x70, 0x20, 0x6f, 0x66, 0x66, 0x73, 0x65, 0x74, 0x3d, 0x22, 0x30, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x63, 0x6f, 0x6c, 0x6f, 0x72, 0x3d, 0x22, 0x23, 0x62, 0x62, 0x62, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x31, 0x22, 0x2f, 0x3e, 0x3c, 0x73, 0x74, 0x6f, 0x70, 0x20, 0x6f, 0x66, 0x66, 0x73, 0x65, 0x74, 0x3d, 0x22, 0x31, 0x22, 0x20, 0x73, 0x74, 0x6f, 0x70, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x31, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x6c, 0x69, 0x6e, 0x65, 0x61, 0x72, 0x47, 0x72, 0x61, 0x64, 0x69, 0x65, 0x6e, 0x74, 0x3e, 0x3c, 0x6d, 0x61, 0x73, 0x6b, 0x20, 0x69, 0x64, 0x3d, 0x22, 0x61, 0x22, 0x3e, 0x3c, 0x72, 0x65, 0x63, 0x74, 0x20, 0x77, 0x69, 0x64, 0x74, 0x68, 0x3d, 0x22, 0x39, 0x38, 0x22, 0x20, 0x68, 0x65, 0x69, 0x67, 0x68, 0x74, 0x3d, 0x22, 0x32, 0x30, 0x22, 0x20, 0x72, 0x78, 0x3d, 0x22, 0x33, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x66, 0x66, 0x66, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x6d, 0x61, 0x73, 0x6b, 0x3e, 0x3c, 0x67, 0x20, 0x6d, 0x61, 0x73, 0x6b, 0x3d, 0x22, 0x75, 0x72, 0x6c, 0x28, 0x23, 0x61, 0x29, 0x22, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x35, 0x35, 0x35, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x30, 0x20, 0x30, 0x68, 0x33, 0x37, 0x76, 0x32, 0x30, 0x48, 0x30, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x39, 0x66, 0x39, 0x66, 0x39, 0x66, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x33, 0x37, 0x20, 0x30, 0x68, 0x36, 0x31, 0x76, 0x32, 0x30, 0x48, 0x33, 0x37, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x70, 0x61, 0x74, 0x68, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x75, 0x72, 0x6c, 0x28, 0x23, 0x62, 0x29, 0x22, 0x20, 0x64, 0x3d, 0x22, 0x4d, 0x30, 0x20, 0x30, 0x68, 0x39, 0x38, 0x76, 0x32, 0x30, 0x48, 0x30, 0x7a, 0x22, 0x2f, 0x3e, 0x3c, 0x2f, 0x67, 0x3e, 0x3c, 0x67, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x66, 0x66, 0x66, 0x22, 0x20, 0x74, 0x65, 0x78, 0x74, 0x2d, 0x61, 0x6e, 0x63, 0x68, 0x6f, 0x72, 0x3d, 0x22, 0x6d, 0x69, 0x64, 0x64, 0x6c, 0x65, 0x22, 0x20, 0x66, 0x6f, 0x6e, 0x74, 0x2d, 0x66, 0x61, 0x6d, 0x69, 0x6c, 0x79, 0x3d, 0x22, 0x44, 0x65, 0x6a, 0x61, 0x56, 0x75, 0x20, 0x53, 0x61, 0x6e, 0x73, 0x2c, 0x56, 0x65, 0x72, 0x64, 0x61, 0x6e, 0x61, 0x2c, 0x47, 0x65, 0x6e, 0x65, 0x76, 0x61, 0x2c, 0x73, 0x61, 0x6e, 0x73, 0x2d, 0x73, 0x65, 0x72, 0x69, 0x66, 0x22, 0x20, 0x66, 0x6f, 0x6e, 0x74, 0x2d, 0x73, 0x69, 0x7a, 0x65, 0x3d, 0x22, 0x31, 0x31, 0x22, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x31, 0x38, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x35, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x30, 0x31, 0x30, 0x31, 0x30, 0x31, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x33, 0x22, 0x3e, 0x62, 0x75, 0x69, 0x6c, 0x64, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x31, 0x38, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x34, 0x22, 0x3e, 0x62, 0x75, 0x69, 0x6c, 0x64, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x36, 0x36, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x35, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x3d, 0x22, 0x23, 0x30, 0x31, 0x30, 0x31, 0x30, 0x31, 0x22, 0x20, 0x66, 0x69, 0x6c, 0x6c, 0x2d, 0x6f, 0x70, 0x61, 0x63, 0x69, 0x74, 0x79, 0x3d, 0x22, 0x2e, 0x33, 0x22, 0x3e, 0x75, 0x6e, 0x6b, 0x6e, 0x6f, 0x77, 0x6e, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x74, 0x65, 0x78, 0x74, 0x20, 0x78, 0x3d, 0x22, 0x36, 0x36, 0x2e, 0x35, 0x22, 0x20, 0x79, 0x3d, 0x22, 0x31, 0x34, 0x22, 0x3e, 0x75, 0x6e, 0x6b, 0x6e, 0x6f, 0x77, 0x6e, 0x3c, 0x2f, 0x74, 0x65, 0x78, 0x74, 0x3e, 0x3c, 0x2f, 0x67, 0x3e, 0x3c, 0x2f, 0x73, 0x76, 0x67, 0x3e };
        private const int BuildUnknownLength = 739;
        public static Response BuildUnknownResponse { get; } =   new Response {
                                                                            ContentType = SvgContentType,
                                                                            Contents = stream => stream.Write(BuildUnknown, 0, BuildUnknownLength),
                                                                            Headers =   { 
                                                                                            { "Content-Disposition", "inline;filename=BuildUnknown.svg" },
                                                                                            { "Pragma", "no-cache"},
                                                                                            {"Cache-Control", "no-store, no-cache, must-revalidate, pre-check=0, post-check=0, max-age=0"},
                                                                                            {"Expires", "-1"}
                                                                                        }
                                                                        }; 
    }
}