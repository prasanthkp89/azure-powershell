// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using AutoMapper;
using FROM = Microsoft.Azure.Management.Compute.Models;
using TO = Microsoft.Azure.Commands.Compute.Automation.Models;

namespace Microsoft.Azure.Commands.Compute.Automation.Models
{
    public class ComputeAutomationAutoMapperProfile : AutoMapper.Profile
    {
        private static IMapper _mapper = null;

        private static readonly object _lock = new object();

        public static IMapper Mapper
        {
            get
            {
                lock(_lock)
                {
                    if (_mapper == null)
                    {
                        Initialize();
                    }

                    return _mapper;
                }
            }
        }

        public override string ProfileName
        {
            get { return "ComputeAutomationAutoMapperProfile"; }
        }

        private static void Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FROM.AvailabilitySet, TO.PSAvailabilitySetList>();
                cfg.CreateMap<TO.PSAvailabilitySetList, TO.PSAvailabilitySet>();
                cfg.CreateMap<TO.PSAvailabilitySet, TO.PSAvailabilitySetList>();
                cfg.CreateMap<FROM.ContainerService, TO.PSContainerServiceList>();
                cfg.CreateMap<TO.PSContainerServiceList, TO.PSContainerService>();
                cfg.CreateMap<TO.PSContainerService, TO.PSContainerServiceList>();
                cfg.CreateMap<FROM.Disk, TO.PSDiskList>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSDiskList, TO.PSDisk>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSDisk, TO.PSDiskList>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<FROM.Image, TO.PSImageList>();
                cfg.CreateMap<TO.PSImageList, TO.PSImage>();
                cfg.CreateMap<TO.PSImage, TO.PSImageList>();
                cfg.CreateMap<FROM.Snapshot, TO.PSSnapshotList>();
                cfg.CreateMap<TO.PSSnapshotList, TO.PSSnapshot>();
                cfg.CreateMap<TO.PSSnapshot, TO.PSSnapshotList>();
                cfg.CreateMap<FROM.VirtualMachineScaleSet, TO.PSVirtualMachineScaleSetList>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSVirtualMachineScaleSetList, TO.PSVirtualMachineScaleSet>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSVirtualMachineScaleSet, TO.PSVirtualMachineScaleSetList>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<FROM.VirtualMachineScaleSet, TO.PSVirtualMachineScaleSetList>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSVirtualMachineScaleSetList, TO.PSVirtualMachineScaleSet>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSVirtualMachineScaleSet, TO.PSVirtualMachineScaleSetList>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<FROM.VirtualMachineScaleSetVM, TO.PSVirtualMachineScaleSetVMList>();
                cfg.CreateMap<TO.PSVirtualMachineScaleSetVMList, TO.PSVirtualMachineScaleSetVM>();
                cfg.CreateMap<TO.PSVirtualMachineScaleSetVM, TO.PSVirtualMachineScaleSetVMList>();
                cfg.CreateMap<FROM.VirtualMachine, TO.PSVirtualMachineList>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSVirtualMachineList, TO.PSVirtualMachine>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSVirtualMachine, TO.PSVirtualMachineList>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<FROM.VirtualMachine, TO.PSVirtualMachineList>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSVirtualMachineList, TO.PSVirtualMachine>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSVirtualMachine, TO.PSVirtualMachineList>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<FROM.Disk, FROM.DiskUpdate>();
                cfg.CreateMap<FROM.DiskUpdate, FROM.Disk>();
                cfg.CreateMap<FROM.DiskUpdate, TO.PSDiskUpdate>();
                cfg.CreateMap<TO.PSDiskUpdate, FROM.DiskUpdate>();
                cfg.CreateMap<FROM.Snapshot, FROM.SnapshotUpdate>();
                cfg.CreateMap<FROM.SnapshotUpdate, FROM.Snapshot>();
                cfg.CreateMap<FROM.SnapshotUpdate, TO.PSSnapshotUpdate>();
                cfg.CreateMap<TO.PSSnapshotUpdate, FROM.SnapshotUpdate>();
                cfg.CreateMap<FROM.AvailabilitySet, TO.PSAvailabilitySet>();
                cfg.CreateMap<TO.PSAvailabilitySet, FROM.AvailabilitySet>();
                cfg.CreateMap<FROM.OperationStatusResponse, TO.PSOperationStatusResponse>();
                cfg.CreateMap<TO.PSOperationStatusResponse, FROM.OperationStatusResponse>();
                cfg.CreateMap<FROM.VirtualMachineSize, TO.PSVirtualMachineSize>();
                cfg.CreateMap<TO.PSVirtualMachineSize, FROM.VirtualMachineSize>();
                cfg.CreateMap<FROM.ContainerService, TO.PSContainerService>();
                cfg.CreateMap<TO.PSContainerService, FROM.ContainerService>();
                cfg.CreateMap<FROM.Disk, TO.PSDisk>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSDisk, FROM.Disk>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<FROM.AccessUri, TO.PSAccessUri>();
                cfg.CreateMap<TO.PSAccessUri, FROM.AccessUri>();
                cfg.CreateMap<FROM.Image, TO.PSImage>();
                cfg.CreateMap<TO.PSImage, FROM.Image>();
                cfg.CreateMap<FROM.LogAnalyticsOperationResult, TO.PSLogAnalyticsOperationResult>();
                cfg.CreateMap<TO.PSLogAnalyticsOperationResult, FROM.LogAnalyticsOperationResult>();
                cfg.CreateMap<FROM.ResourceSku, TO.PSResourceSku>();
                cfg.CreateMap<TO.PSResourceSku, FROM.ResourceSku>();
                cfg.CreateMap<FROM.Snapshot, TO.PSSnapshot>();
                cfg.CreateMap<TO.PSSnapshot, FROM.Snapshot>();
                cfg.CreateMap<FROM.RunCommandDocument, TO.PSRunCommandDocument>();
                cfg.CreateMap<TO.PSRunCommandDocument, FROM.RunCommandDocument>();
                cfg.CreateMap<FROM.RunCommandDocumentBase, TO.PSRunCommandDocumentBase>();
                cfg.CreateMap<TO.PSRunCommandDocumentBase, FROM.RunCommandDocumentBase>();
                cfg.CreateMap<FROM.RollingUpgradeStatusInfo, TO.PSRollingUpgradeStatusInfo>();
                cfg.CreateMap<TO.PSRollingUpgradeStatusInfo, FROM.RollingUpgradeStatusInfo>();
                cfg.CreateMap<FROM.VirtualMachineScaleSet, TO.PSVirtualMachineScaleSet>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSVirtualMachineScaleSet, FROM.VirtualMachineScaleSet>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<FROM.RecoveryWalkResponse, TO.PSRecoveryWalkResponse>();
                cfg.CreateMap<TO.PSRecoveryWalkResponse, FROM.RecoveryWalkResponse>();
                cfg.CreateMap<FROM.VirtualMachineScaleSetInstanceView, TO.PSVirtualMachineScaleSetInstanceView>();
                cfg.CreateMap<TO.PSVirtualMachineScaleSetInstanceView, FROM.VirtualMachineScaleSetInstanceView>();
                cfg.CreateMap<FROM.VirtualMachineScaleSetSku, TO.PSVirtualMachineScaleSetSku>();
                cfg.CreateMap<TO.PSVirtualMachineScaleSetSku, FROM.VirtualMachineScaleSetSku>();
                cfg.CreateMap<FROM.VirtualMachineScaleSetVM, TO.PSVirtualMachineScaleSetVM>();
                cfg.CreateMap<TO.PSVirtualMachineScaleSetVM, FROM.VirtualMachineScaleSetVM>();
                cfg.CreateMap<FROM.VirtualMachineScaleSetVMInstanceView, TO.PSVirtualMachineScaleSetVMInstanceView>();
                cfg.CreateMap<TO.PSVirtualMachineScaleSetVMInstanceView, FROM.VirtualMachineScaleSetVMInstanceView>();
                cfg.CreateMap<FROM.VirtualMachineCaptureResult, TO.PSVirtualMachineCaptureResult>();
                cfg.CreateMap<TO.PSVirtualMachineCaptureResult, FROM.VirtualMachineCaptureResult>();
                cfg.CreateMap<FROM.VirtualMachine, TO.PSVirtualMachine>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSVirtualMachine, FROM.VirtualMachine>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<FROM.VirtualMachineInstanceView, TO.PSVirtualMachineInstanceView>();
                cfg.CreateMap<TO.PSVirtualMachineInstanceView, FROM.VirtualMachineInstanceView>();
                cfg.CreateMap<FROM.RunCommandResult, TO.PSRunCommandResult>();
                cfg.CreateMap<TO.PSRunCommandResult, FROM.RunCommandResult>();

            });
            _mapper = config.CreateMapper();
        }
    }
}