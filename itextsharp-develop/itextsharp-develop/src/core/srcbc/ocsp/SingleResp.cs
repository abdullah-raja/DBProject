/*
    This file is part of the iText (R) project.
    Copyright (c) 1998-2019 iText Group NV
    Authors: iText Software.

This program is free software; you can redistribute it and/or modify it under the terms of the GNU Affero General Public License version 3 as published by the Free Software Foundation with the addition of the following permission added to Section 15 as permitted in Section 7(a): FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY iText Group NV, iText Group NV DISCLAIMS THE WARRANTY OF NON INFRINGEMENT OF THIRD PARTY RIGHTS.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License along with this program; if not, see http://www.gnu.org/licenses or write to the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA, 02110-1301 USA, or download the license from the following URL:

http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions of this program must display Appropriate Legal Notices, as required under Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License, a covered work must retain the producer line in every PDF that is created or manipulated using iText.

You can be released from the requirements of the license by purchasing a commercial license. Buying such a license is mandatory as soon as you develop commercial activities involving the iText software without disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP, serving PDFs on the fly in a web application, shipping iText with a closed source product.

For more information, please contact iText Software Corp. at this address: sales@itextpdf.com */
using System;
using System.Collections;

using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Ocsp
{
	public class SingleResp
		: X509ExtensionBase
	{
		internal readonly SingleResponse resp;

		public SingleResp(
			SingleResponse resp)
		{
			this.resp = resp;
		}

		public CertificateID GetCertID()
		{
			return new CertificateID(resp.CertId);
		}

		/**
		 * Return the status object for the response - null indicates good.
		 *
		 * @return the status object for the response, null if it is good.
		 */
		public object GetCertStatus()
		{
			CertStatus s = resp.CertStatus;

			if (s.TagNo == 0)
			{
				return null;            // good
			}

			if (s.TagNo == 1)
			{
				return new RevokedStatus(RevokedInfo.GetInstance(s.Status));
			}

			return new UnknownStatus();
		}

		public DateTime ThisUpdate
		{
			get { return resp.ThisUpdate.ToDateTime(); }
		}

		/**
		* return the NextUpdate value - note: this is an optional field so may
		* be returned as null.
		*
		* @return nextUpdate, or null if not present.
		*/
		public DateTimeObject NextUpdate
		{
			get
			{
				return resp.NextUpdate == null
					?	null
					:	new DateTimeObject(resp.NextUpdate.ToDateTime());
			}
		}

		public X509Extensions SingleExtensions
		{
			get { return resp.SingleExtensions; }
		}

		protected override X509Extensions GetX509Extensions()
		{
			return SingleExtensions;
		}
	}
}
