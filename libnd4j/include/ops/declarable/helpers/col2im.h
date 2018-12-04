/*******************************************************************************
 * Copyright (c) 2015-2018 Skymind, Inc.
 *
 * This program and the accompanying materials are made available under the
 * terms of the Apache License, Version 2.0 which is available at
 * https://www.apache.org/licenses/LICENSE-2.0.
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 *
 * SPDX-License-Identifier: Apache-2.0
 ******************************************************************************/

//
// Created by raver119 on 30.11.17.
//

#ifndef LIBND4J_COL2IM_H
#define LIBND4J_COL2IM_H

#include <ops/declarable/helpers/helpers.h>

namespace nd4j {
    namespace ops {
        namespace helpers {
            template <typename T>
            void _col2im(nd4j::graph::LaunchContext& context, T *dst, T *src, Nd4jLong *outShape, Nd4jLong *inShape, int sY, int sX, int pY, int pX, int imgY, int imgX, int dY, int dX);
        }
    }
}


#endif //LIBND4J_COL2IM_H