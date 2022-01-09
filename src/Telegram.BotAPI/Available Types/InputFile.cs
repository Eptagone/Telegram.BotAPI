// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents the contents of a file to be uploaded. Must be posted using multipart/form-data in the usual way that files are uploaded via the browser.</summary>
    public sealed class InputFile : IEquatable<InputFile>
    {
        /// <summary>HTTP file content.</summary>
        [JsonIgnore]
        public StreamContent Content { get; private set; }
        /// <summary>File name.</summary>
        [JsonIgnore]
        public string Filename { get; private set; }
        /// <summary>New InputFile.</summary>
        /// <param name="streamcontent">HTTP file content.</param>
        /// <param name="filename">File name.</param>
        public InputFile(StreamContent streamcontent, string filename)
        {
            Content = streamcontent;
            Filename = filename;
        }
        /// <summary>New InputFile.</summary>
        /// <param name="streamfile">Stream file.</param>
        /// <param name="filename">File name.</param>
        public InputFile(MemoryStream streamfile, string filename)
        {
            Content = new StreamContent(streamfile);
            Filename = filename;
        }
        /// <summary>New InputFile.</summary>
        /// <param name="file">File.</param>
        /// <param name="filename">File name.</param>
        public InputFile(byte[] file, string filename)
        {
            Content = new StreamContent(new MemoryStream(file));
            Filename = filename;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InputFile);
        }

        public bool Equals(InputFile other)
        {
            return other != null &&
                   EqualityComparer<StreamContent>.Default.Equals(Content, other.Content) &&
                   Filename == other.Filename;
        }

        public override int GetHashCode()
        {
            int hashCode = 1463301466;
            hashCode = hashCode * -1521134295 + EqualityComparer<StreamContent>.Default.GetHashCode(Content);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Filename);
            return hashCode;
        }

        public static bool operator ==(InputFile left, InputFile right)
        {
            return EqualityComparer<InputFile>.Default.Equals(left, right);
        }

        public static bool operator !=(InputFile left, InputFile right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
    /// <summary>This object represents a attached file.</summary>
    public sealed class AttachedFile
    {
        /// <summary>AttachFile Name</summary>
        public string Name { get; }
        /// <summary>File</summary>
        public InputFile File { get; }
        /// <summary>New AttachFile</summary>
        /// <param name="name">File attach name.</param>
        /// <param name="inputFile">This object represents the contents of a file to be uploaded.</param>
        public AttachedFile(string name, InputFile inputFile)
        {
            Name = name;
            File = inputFile;
        }
    }
}
