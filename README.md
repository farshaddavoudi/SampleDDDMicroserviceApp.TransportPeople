

# Domain-Driven Design:
 - Pure rich domain models disregarding of persistence concerns
 - Using advanced LINQ queries in order to join between tables as a result of not having navigation properties
 - Pusing logics down to the domain project by using patterns such as Double Dispatch pattern
 - Application project is merely a request orchestrator containing use cases and routes the requests to the Domain layer. Not much logic there anymore as most logic is pushing down to Domain layer.
