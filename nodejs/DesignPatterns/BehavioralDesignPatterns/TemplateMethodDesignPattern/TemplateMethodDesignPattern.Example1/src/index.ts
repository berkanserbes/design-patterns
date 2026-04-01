// ============================================================================
// TEMPLATE METHOD DESIGN PATTERN
// ============================================================================
// Template Method defines the skeleton of an algorithm in a base class and
// lets subclasses override specific steps without changing the overall structure.
//
// Pattern Structure:
//   - RecruitmentProcess: Abstract class with the template method
//   - executeRecruitmentProcess(): Template method — fixed algorithm skeleton
//   - technicalInterview(): Abstract step — each subclass must implement
//   - interviewWithManager(), notifyCandidate(): Hooks — optional overrides
// ============================================================================

import { BlueCollarRecruitmentProcess } from "./BlueCollarRecruitmentProcess";
import { DeveloperRecruitmentProcess } from "./DeveloperRecruitmentProcess";
import { RecruitmentProcess } from "./RecruitmentProcess";
import { WhiteCollarRecruitmentProcess } from "./WhiteCollarRecruitmentProcess";

const processes: RecruitmentProcess[] = [
  new WhiteCollarRecruitmentProcess(),
  new BlueCollarRecruitmentProcess(),
  new DeveloperRecruitmentProcess(),
];

for (const process of processes) {
  console.log(`\n--- ${process.constructor.name} ---`);
  process.executeRecruitmentProcess();
}
