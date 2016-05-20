#region Copyright (c) 2016 Atif Aziz. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

namespace WebLinq
{
    public static class Query
    {
        public static HttpSpec Http => new HttpSpec();

        public static Query<T> Return<T>(T value) =>
            new Query<T>(context => new QueryResult<T>(context, value));

        public static Query<IParsedHtml> Html(string html) =>
            new Query<IParsedHtml>(context => QueryResult.Create(context, context.Eval((IHtmlParser hps) => hps.Parse(html))));
    }
}
