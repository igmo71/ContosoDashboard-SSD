<!--
Sync Impact Report
Version change: uninitialized → 1.0.0
Modified principles: placeholders → Training-first delivery; Security-aware training; Spec-driven workflow; Simple, portable architecture; Documentation and alignment
Added sections: Development Constraints; Development Workflow
Removed sections: none
Templates reviewed: ✅ .specify/templates/plan-template.md (reviewed), ✅ .specify/templates/spec-template.md (reviewed), ✅ .specify/templates/tasks-template.md (reviewed), ✅ .specify/templates/constitution-template.md (source template)
Follow-up TODOs: none
-->

# ContosoDashboard Constitution

## Core Principles

### Training-first delivery
ContosoDashboard exists first as a training artifact. Every implementation decision must preserve offline availability,
clear learning value, and mock-friendly architecture rather than production-ready complexity.

### Security-aware training
Security practices are demonstrated with explicit caveats: authorization and service-level checks MUST be implemented,
but mock authentication and local-only infrastructure are acceptable for the training scope.

### Spec-driven workflow
All feature work MUST follow the GitHub Spec Kit workflow: define specifications, produce a plan, generate tasks,
and implement only after the plan and task artifacts align with the constitution.

### Simple, portable architecture
The codebase MUST favor simplicity, separation of concerns, and portability. Infrastructure abstractions should be used
where they enable migration paths, but the current implementation must remain easy to understand and run locally.

### Documentation and alignment
Documentation, guidance, and project metadata MUST reflect the actual implementation and training purpose.
Artifacts such as README.md, templates, and Spec Kit documents MUST stay synchronized with the repository's design.

## Development Constraints
The project is constrained to training-oriented, offline-capable development:
- Use local-first infrastructure by default.
- Explicitly label mock or placeholder implementations as training-specific.
- Avoid introducing production-only cloud services or external service dependencies without a documented migration path.
- Preserve the pedagogical structure of the app so students can trace feature behavior from spec to implementation.

## Development Workflow
The repository uses a Spec Kit workflow with clearly defined artifacts and gates:
- `/speckit.specify` sets the feature spec.
- `/speckit.plan` produces a technical plan and a constitution check.
- `/speckit.tasks` generates dependency-ordered tasks for implementation.
- `/speckit.implement` carries out work only after the above artifacts exist and comply with the constitution.

Code review and change approval MUST validate that work remains aligned with these principles, especially when updates touch security,
training assumptions, or platform/runtime configuration.

## Governance
This constitution is the authoritative source for project-level guidance and supersedes informal or undocumented practices.
Amendments require an explicit update to this document and a review of dependent Spec Kit artifacts to ensure consistency.

- All PRs and reviews MUST verify that changes remain compatible with the constitution.
- Major architectural deviations or production migration changes REQUIRE a constitution amendment.
- Training-specific shortcuts and mock implementations MUST be clearly documented and not silently preserved as production behavior.
- Cross-artifact consistency MUST be maintained between constitution, plan, spec, tasks, and runtime guidance.

**Version**: 1.0.0 | **Ratified**: 2026-06-03 | **Last Amended**: 2026-06-03
